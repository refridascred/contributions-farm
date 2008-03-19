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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = (score + (long)i) % 1000;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + ((long)i >> 3)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
