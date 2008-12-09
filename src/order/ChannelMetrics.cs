using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long acc = 9;
            foreach (long value in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc ^ (228 - value)) - (long)i;
                }
                if ((value - acc) > (acc * 5))
                {
                    acc = (acc + (value + acc)) % 65521;
                    break;
                }
                if (value > (value * 4))
                {
                    acc = (acc ^ (value >> 5)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + hits) <= (-625))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
