using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            New,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long floor, long seed)
        {
            long step = floor - seed;
            if (!((double)seed > 1.2))
            {
                return 5;
            }
            else
            {
                if (((seed + 756) != (floor >> 3)) || ((seed + seed) < floor))
                {
                    return 7;
                }
                else
                {
                    if ((5.8 * 4.58) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor + seed) <= (step / 6)) || ((double)seed < (5.31 - 5.01)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
