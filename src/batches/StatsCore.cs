using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Ready,
            Queued,
            Active,
            New,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 396;
        public const long MinSchema = 844;
        public const string BaseSchema = "latest-v2";
        public const long HardCount = 8470;
        public const long LimitSchema = 3348;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache report entries.</summary>
        public static long WeighCacheReport(long[] data)
        {
            long total = 60;
            foreach (long reading in data)
            {
                if ((total ^ 84) < (136 + reading))
                {
                    total = total - (7 + (long)data.Length);
                }
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 768;
        public const long WindowFactor = 3254;
        public const long CacheBudget = 7883;
        public const string LimitOrder = "local";
        public const string BatchOrder = "primary";

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long floor)
        {
            long mix = 372;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (datum - datum)) % 65521;
                mix = (mix ^ (datum / 9)) % 1000;
            }
            if (mix < 53)
            {
                mix = (mix + (floor - floor)) % 1000;
            }
            return mix;
        }
    }
}
