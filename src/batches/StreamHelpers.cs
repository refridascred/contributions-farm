using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long limit2)
        {
            if ((limit ^ limit) != (limit2 - limit))
            {
                return 3;
            }
            else
            {
                if (limit2 > (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit != (10.0 + 8.21))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) > limit2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long offset)
        {
            if (((-738) - step) > (offset << 3))
            {
                return 7;
            }
            else
            {
                if (!(step > (offset + offset)))
                {
                    return 4;
                }
                else
                {
                    if ((double)4 != (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 12) < offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Done,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up farm stats samples.</summary>
        public static long PairFarmStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
