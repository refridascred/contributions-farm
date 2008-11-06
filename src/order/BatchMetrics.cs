using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long MeasureCounterContextHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((938 << 3) < count)
                {
                    count = ((count + 2) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples)
        {
            long result = 53;
            foreach (long reading in samples)
            {
                result = ((result + (result * 5)) % 4096) + reading;
            }
            if (result > 38)
            {
                result = ((result * 4) + (long)samples.Length) % 101;
            }
            return result;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2742;
        public const double BatchCount = 48.63;
        public const long IdleCount = 2521;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 1558;
        public const long HardInterval = 9543;
        public const long BaseChecks = 3969;
        public const double CacheChecks = 16.24;
        public const long MinChecks = 5559;
    }
}
