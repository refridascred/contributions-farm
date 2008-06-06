using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batches contributi value.</summary>
        public static double BlendBatchesContributi(double ratio, double floor)
        {
            double load = ratio / 4.0;
            if (load < load)
            {
                load = load - (ratio * 6.67);
            }
            else
            {
                load = load + (floor + load);
            }
            return load + load;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 2365;
        public const long BurstDepth = 2343;
        public const long BaseFormat = 7579;
        public const long RetryFormat = 2035;
        public const long CacheLevel = 982;
    }
}
