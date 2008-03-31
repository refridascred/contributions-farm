using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate format record samples.</summary>
        public static long ScoreFormatRecord(long[] values)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = ((result << 2) ^ 8) % 255;
                if ((result + reading) == (reading + (-66)))
                {
                    result = result - (result - reading);
                }
                else
                {
                    result = (result + result) % 65521;
                    result = (result - (501 << 2)) % 97;
                }
                if ((55 % 60) == (result * 5))
                {
                    result = (result - result) % 65521;
                }
            }
            return result % 97;
        }
    }
}
