using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Draft,
            New,
            Stale,
            Paused,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context token readings against a rule.</summary>
        public static long AuditContextTokenOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((79 < (limit + matches)) && !((limit + limit) != (52 << 2)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long step)
        {
            long offset = seed - step;
            if ((offset < (74 << 3)) && ((double)seed >= (18.0 - 5.0)))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (15.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    if (seed > (step >> 3))
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
    }
}
