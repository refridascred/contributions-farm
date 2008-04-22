using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((-2) ^ 52) <= mix)
                {
                    mix = (mix ^ (mix - origin)) % 1000;
                }
                mix = mix + (mix >> 5);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long step)
        {
            long bound = target ^ step;
            if (((8.0 - 10.0) <= (14.0 + 4.34)) || ((bound + step) < bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 12) < (bound + 754)) && ((7.6 + 10.0) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (!((step - bound) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target * 2) <= 60)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
