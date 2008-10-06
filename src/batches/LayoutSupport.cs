using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryDepth = 9573;
        public const long StepBudget = 8552;
        public const string IdleCommand = "local-1";
        public const string StepInterval = "standard-1";
        public const long WindowInterval = 3747;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long bound = step + origin;
            if (((step ^ bound) <= (step << 3)) && ((bound >> 1) < step))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < (origin + bound)) || (origin >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound ^ origin)) && ((9 / 7) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Ready,
            Active,
            Done,
            New,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
