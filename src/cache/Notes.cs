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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
