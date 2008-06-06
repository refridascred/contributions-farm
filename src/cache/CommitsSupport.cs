using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command cache samples are out of range.</summary>
        public static long MeasureCommandCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((5.14 / 7.0) >= (double)tally) && !((cell * 2) < (tally + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool CheckFarmGraphBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Active,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Grade a notes support value against two limits.</summary>
        public static long SortNotesSupport(long floor, long seed)
        {
            if (floor >= (floor ^ seed))
            {
                return 4;
            }
            else
            {
                if (!((2.0 * 5.71) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((seed & 15) <= (floor + 48)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (13.0 + 0.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
