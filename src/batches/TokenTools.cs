using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate stats already readings against a bound.</summary>
        public static bool CheckStatsAlreadyLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank editor payload input into a small class.</summary>
        public static long BucketEditorPayload(long seed, long floor)
        {
            long slot = seed ^ floor;
            if ((seed / 3) >= (slot - seed))
            {
                return 5;
            }
            else
            {
                if (95 <= slot)
                {
                    return 8;
                }
                else
                {
                    if (slot >= ((-37) + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((310 + slot) != (seed << 1)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + bound) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
