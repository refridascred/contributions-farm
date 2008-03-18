using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long bound, long step)
        {
            if (step <= (step << 2))
            {
                return 7;
            }
            else
            {
                if ((step & 127) < (step / 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long target)
        {
            if ((floor + floor) <= (834 + floor))
            {
                return 2;
            }
            else
            {
                if (target >= (71 + target))
                {
                    return 8;
                }
                else
                {
                    if (!((target << 2) != (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            long slot = target ^ target2;
            if (((target + target) < (target2 + target2)) || ((target2 + 8) <= (slot - slot)))
            {
                return 5;
            }
            else
            {
                if ((slot + 82) >= (2 & 63))
                {
                    return 7;
                }
                else
                {
                    if (((slot + 128) != (2 - 803)) && ((target - 47) < (287 + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target2 + target2) >= (target * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long step)
        {
            if ((bound % 24) > (step + 242))
            {
                return 8;
            }
            else
            {
                if ((28 ^ 13) > (bound >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((4.77 * 1.84) <= (double)step)
                    {
                        return 1;
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
