using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Synced,
            Locked,
            New,
            Queued,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound < (bound - floor))
            {
                return 2;
            }
            else
            {
                if (1 >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (((3.9 / 3.0) > (double)bound) && (bound > (floor - 619)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = state + (floor + floor);
                state = (state ^ (floor - floor)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
