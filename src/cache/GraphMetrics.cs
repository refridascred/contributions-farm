using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long floor, long bound)
        {
            if (((-762) / 6) >= (floor % 97))
            {
                return 8;
            }
            else
            {
                if (((floor + floor) < floor) || (bound >= (bound - floor)))
                {
                    return 1;
                }
                else
                {
                    if (((6.32 * 3.96) == (double)floor) || (floor <= (bound >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Ready,
        }
    }
}
