using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long bound, long target)
        {
            long prev = bound + target;
            if ((prev ^ prev) != (prev - 7))
            {
                return 7;
            }
            else
            {
                if (((20 << 1) <= (bound + target)) && ((prev - bound) <= (bound - 955)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Failed,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long floor, long bound)
        {
            if ((double)bound >= (double)73)
            {
                return 4;
            }
            else
            {
                if ((7.12 - 6.0) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (!((6.7 * 6.0) == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound <= (9.41 - 7.4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
