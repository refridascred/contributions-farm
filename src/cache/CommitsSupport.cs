using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a checks record reading by value.</summary>
        public static long FindChecksRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long origin, long target)
        {
            if (!((origin & 127) != (52 + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin * 3) <= (origin - origin)) && ((target - target) <= (9 * 5)))
                {
                    return 2;
                }
                else
                {
                    if (((double)target >= (5.7 + 0.96)) || ((origin << 1) > (26 + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long ClassifyContributiWindow(long bound, long target)
        {
            if ((double)bound <= (3.0 + 7.0))
            {
                return 4;
            }
            else
            {
                if ((16 - bound) < bound)
                {
                    return 8;
                }
                else
                {
                    if (bound >= (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 2) != (0 ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command entry measurements.</summary>
        public static double SmoothCommandEntry(double gain, double bias)
        {
            double scale = (double)60 / 5.0;
            return ((scale + (double)4) + gain) + bias;
        }
    }
}
