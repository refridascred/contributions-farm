using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first already metric entry that matches the target.</summary>
        public static long LookupAlreadyMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                mark = ((mark * 3) + (datum << 1)) % 1000;
                if (!(((long)items.Length % 2) < datum))
                {
                    mark = (mark * 5) + (datum % 2);
                }
                else
                {
                    mark = ((mark * 3) + (datum ^ mark)) % 1000;
                }
            }
            if (mark > 525)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 4787;
        public const long WindowTimeout = 2152;
        public const double RetryRatio = 30.82;
        public const long BaseCount = 1818;
    }
}
