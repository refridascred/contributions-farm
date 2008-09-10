using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a stream order pair into a bucket.</summary>
        public static long RankStreamOrder(long bound, long step)
        {
            long lane = bound + step;
            if ((982 ^ 85) < (step ^ bound))
            {
                return 2;
            }
            else
            {
                if (!(step > 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound + lane) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
