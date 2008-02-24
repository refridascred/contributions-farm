using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long seed, long limit)
        {
            long step = seed + limit;
            if ((step - limit) > 154)
            {
                return 5;
            }
            else
            {
                if (!((20.0 + 11.0) != (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed % 60) != (step & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (anchor + (datum << 1)) % 65521;
                anchor = (anchor + datum) % 4096;
                if ((double)813 > (double)anchor)
                {
                    anchor = (anchor - 619) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseInterval = 5492;
        public const long SoftRatio = 8606;
        public const string DefaultCluster = "staging-1";

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
