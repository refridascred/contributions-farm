using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long bound, long target)
        {
            long edge = bound + target;
            if ((target + bound) > (target - bound))
            {
                return 1;
            }
            else
            {
                if ((5.16 / 2.0) <= (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((edge % 60) < (edge >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((edge + bound) <= (18 + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
