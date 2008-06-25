using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long floor, long offset)
        {
            long delta = floor + offset;
            if ((delta << 2) <= delta)
            {
                return 3;
            }
            else
            {
                if ((offset + offset) < (delta - 432))
                {
                    return 6;
                }
                else
                {
                    if ((floor + offset) >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + 84) > (delta * 4))
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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Iterate the cluster entry series from a seed.</summary>
        public static long SeriesClusterEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (((-5) + target) != (result - (long)i))
                {
                    result = (result + (target * 4)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell * 5) >= 354)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
