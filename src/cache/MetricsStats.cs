using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            New,
            Locked,
            Active,
        }

        /// <summary>Grade a cluster contributi value against two limits.</summary>
        public static long GradeClusterContributi(long floor, long step)
        {
            long delta = floor - step;
            if ((floor / 2) == (step / 4))
            {
                return 4;
            }
            else
            {
                if (((166 ^ step) > (floor + step)) || ((double)delta >= (double)29))
                {
                    return 5;
                }
                else
                {
                    if ((floor ^ step) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long origin, long offset)
        {
            long next = origin + offset;
            if (!(origin <= (next & 15)))
            {
                return 8;
            }
            else
            {
                if (((-292) - offset) > (origin - 1))
                {
                    return 4;
                }
                else
                {
                    if (!(offset >= (next / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long TallyFarmMetricsMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item < (3.4 * 5.65))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
