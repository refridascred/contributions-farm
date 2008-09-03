using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report batch value against two limits.</summary>
        public static long BucketReportBatch(long seed, long offset)
        {
            if ((19.0 / 4.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((1.07 - 20.0) == (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 82;
            foreach (long cell in items)
            {
                acc = (acc - (783 << 2)) % 101;
                acc = (acc << 3) ^ (acc + cell);
            }
            if (acc < (-468))
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Ready,
            Retry,
        }
    }
}
