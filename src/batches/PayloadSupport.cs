using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((double)bound < (1.0 * 4.0))
            {
                return 8;
            }
            else
            {
                if ((seed ^ 68) <= (8 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (((bound + seed) <= bound) && ((seed / 2) == (seed / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long bound)
        {
            if ((bound + step) != (68 + step))
            {
                return 1;
            }
            else
            {
                if ((step * 2) >= (step - step))
                {
                    return 6;
                }
                else
                {
                    if (((83 % 10) == (step % 10)) && ((double)step == (4.2 / 3.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) != (bound ^ (-7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long MeasureMetricGithubfarmMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen & 3) >= reading)
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
