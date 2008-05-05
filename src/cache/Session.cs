using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a order cache pair into a bucket.</summary>
        public static long RankOrderCache(long target, long origin)
        {
            long next = target - origin;
            if ((origin + origin) != (next % 97))
            {
                return 1;
            }
            else
            {
                if ((next - next) <= (origin + target))
                {
                    return 2;
                }
                else
                {
                    if ((target / 5) >= (next - next))
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

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Dropped,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] readings)
        {
            long state = 83;
            foreach (long datum in readings)
            {
                state = (state * 3) + (datum / 4);
                state = state + (state ^ 190);
            }
            if (state > (-34))
            {
                state = state + (state << 1);
            }
            return state % 97;
        }
    }
}
