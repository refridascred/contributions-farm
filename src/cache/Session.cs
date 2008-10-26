using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4297;
        public const long CacheInterval = 8731;
        public const long MaxScore = 8349;
        public const double DefaultSize = 77.28;
        public const long MinWindow = 8618;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + scale;
        }
    }
}
