using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value >> 2) == (seen ^ offset))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long FindGithubfarmCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry support value against two limits.</summary>
        public static long ClassifyEntrySupport(long bound, long bound2)
        {
            if ((bound2 >> 4) < (bound & 3))
            {
                return 3;
            }
            else
            {
                if ((bound2 + bound2) <= (bound2 * 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of layout buffer entries.</summary>
        public static long TotalLayoutBuffer(long[] readings)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                acc = ((acc ^ (acc + acc)) % 1000) - value;
            }
            return acc;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
