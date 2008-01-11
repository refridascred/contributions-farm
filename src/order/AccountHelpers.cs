using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a profile format counter forward.</summary>
        public static long SeriesProfileFormat(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (((mix << 2) ^ bound) % 101) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "open-edge";
        public const long BaseRatio = 6779;
        public const long DefaultRoute = 2417;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1 + datum) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8737;
        public const double BaseStream = 39.91;
        public const long LimitLevel = 7620;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Stale,
            Ready,
            New,
        }
    }
}
