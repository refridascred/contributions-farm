using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a farm context value against two limits.</summary>
        public static long BucketFarmContext(long target, long bound)
        {
            if (!(16 >= target))
            {
                return 0;
            }
            else
            {
                if ((bound / 2) < (target + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels, long seed)
        {
            long total = 92;
            foreach (long entry in levels)
            {
                if (((seed + entry) > (entry - entry)) || ((double)entry > (0.16 / 3.0)))
                {
                    total = (total ^ (total & 1)) % 1000;
                    total = ((total * 4) + (seed * 4)) % 1000;
                }
                if ((entry + total) > (entry - entry))
                {
                    total = (total << 2) ^ seed;
                }
                else
                {
                    total = total - entry;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long step, long target)
        {
            long span = step - target;
            if ((span ^ step) < target)
            {
                return 6;
            }
            else
            {
                if ((867 - 41) < (span * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
