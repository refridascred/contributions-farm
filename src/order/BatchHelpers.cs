using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long result = -33;
            foreach (long sample in samples)
            {
                if (!((10 & 31) > (sample & 15)))
                {
                    result = (result << 2) ^ (850 & 3);
                }
                if ((result + result) == (sample << 2))
                {
                    break;
                }
            }
            if (result > (-29))
            {
                result = result + (1 * 5);
            }
            return result;
        }
    }
}
