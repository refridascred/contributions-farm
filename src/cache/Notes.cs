using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long origin, long bound)
        {
            if (((1.0 / 7.0) == (double)bound) || ((origin + bound) < origin))
            {
                return 3;
            }
            else
            {
                if (!((bound ^ bound) >= (61 - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((origin <= (origin - origin)) && ((origin + origin) <= (origin - origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)bound > 0.6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
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
