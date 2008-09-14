using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 3) == (seen + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 375;
            foreach (long sample in data)
            {
                if (((mark << 2) <= (offset << 2)) || ((double)sample <= 9.87))
                {
                    mark = (mark ^ (offset - offset)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 5534;
        public const double MinRoute = 94.22;
        public const long DefaultWidth = 5605;
        public const double DefaultSize = 81.94;
        public const long HardRoute = 7234;
    }
}
