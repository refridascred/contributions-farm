using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Done,
            New,
            Stale,
        }

        /// <summary>Count stats batch pairs that satisfy a relation.</summary>
        public static long MatchStatsBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long bound, long limit)
        {
            long delta = bound ^ limit;
            if (limit <= (20 / 7))
            {
                return 4;
            }
            else
            {
                if ((2.06 + 12.0) != (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) == (limit - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit != (3.38 * 16.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
