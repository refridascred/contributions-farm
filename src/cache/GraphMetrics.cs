using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 1932;
        public const long BaseRatio = 6404;
        public const string BurstWidth = "staging-v2";
        public const string DefaultCache = "stable";
        public const long MinBudget = 3544;

        /// <summary>Match up token tools samples.</summary>
        public static long MatchTokenToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (mark + mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double weight = ratio;
            if (weight > (ratio / 7.0))
            {
                weight = weight - (ratio - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (span + span)) + (double)(long)i;
            }
            return weight + (ratio / 3.0);
        }
    }
}
