using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) >= (tally + 86))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 7156;
        public const long BurstAlready = 3528;
        public const double DefaultLevel = 87.4;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 7509;
        public const long IdleQueue = 4741;
        public const string BatchWidth = "alpha-1";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long target)
        {
            if ((double)step < 4.0)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (8.55 * 7.33)) || ((step + target) >= (4 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (!((target & 15) >= (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 1) != (target * 5))
                        {
                            return 7;
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
