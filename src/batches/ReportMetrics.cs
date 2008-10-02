using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long result = 240;
            foreach (long entry in readings)
            {
                if (result <= (entry & 7))
                {
                    result = result + entry;
                }
                else
                {
                    result = (result ^ ((long)readings.Length % 5)) % 255;
                }
                if ((result - 906) < (result / 9))
                {
                    result = (result ^ (result >> 5)) % 65521;
                }
            }
            if (result < 36)
            {
                result = (result << 3) ^ 92;
            }
            return result % 1000;
        }

        /// <summary>Accumulate graph token samples.</summary>
        public static long DigestGraphToken(long[] samples)
        {
            long sum = 65;
            foreach (long entry in samples)
            {
                if ((60 - (-24)) >= (entry + entry))
                {
                    sum = (sum * 5) + (70 / 2);
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
