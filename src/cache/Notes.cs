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

        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long TallyContextGithubfarm(long[] values)
        {
            long total = 51;
            foreach (long sample in values)
            {
                total = ((total << 3) ^ total) % 101;
                total = ((total << 3) ^ sample) % 65521;
            }
            if (total < (-83))
            {
                total = (total * 5) + (total >> 5);
            }
            return total;
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
