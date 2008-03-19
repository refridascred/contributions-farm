using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank contributi checks input into a small class.</summary>
        public static long BucketContributiChecks(long step, long bound)
        {
            long delta = step - bound;
            if ((bound >> 3) <= step)
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (5.0 / 3.0)) || ((bound ^ bound) < bound))
                {
                    return 8;
                }
                else
                {
                    if ((8.5 / 2.0) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)908 >= (double)delta)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long step2)
        {
            if (!((14.0 - 10.0) > (double)step2))
            {
                return 0;
            }
            else
            {
                if ((step2 << 2) > (step2 + step2))
                {
                    return 6;
                }
                else
                {
                    if (((7.0 + 12.0) <= (double)step) || ((double)step2 <= 6.33))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series, long origin)
        {
            long result = -46;
            foreach (long reading in series)
            {
                if (!((62 - origin) <= (origin * 4)))
                {
                    result = result + (reading >> 2);
                }
                else
                {
                    result = result - (reading + result);
                }
            }
            return result;
        }
    }
}
