using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (sample * 2)) ^ (long)i;
                }
                if (limit < acc)
                {
                    acc = acc ^ sample;
                }
                if (limit > (limit - limit))
                {
                    acc = (acc - sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next token githubfarm value from a seed.</summary>
        public static long StepTokenGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long floor)
        {
            long result = 468;
            foreach (long value in items)
            {
                if ((double)value > (5.0 - 0.4))
                {
                    result = ((result - result) % 4096) + floor;
                }
            }
            return result;
        }
    }
}
