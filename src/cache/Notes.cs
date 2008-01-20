using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long span = seed - limit;
            if ((span >> 4) == (seed % 5))
            {
                return 5;
            }
            else
            {
                if (!((limit + limit) != (span ^ span)))
                {
                    return 6;
                }
                else
                {
                    if ((761 ^ span) > 9)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((span - limit) > (5 % 24)) || ((span >> 5) == (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next report tools value.</summary>
        public static double ScaleReportTools(double rate, double bias)
        {
            double load = rate;
            if (load >= bias)
            {
                load = load - (rate + bias);
            }
            return load - (load * 3.0);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long seed, long offset)
        {
            long gap = seed - offset;
            if ((gap + 9) > (offset & 127))
            {
                return 7;
            }
            else
            {
                if (!((gap >> 5) >= (7 ^ gap)))
                {
                    return 6;
                }
                else
                {
                    if ((41 >> 5) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap ^ seed) > 856)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long step)
        {
            if ((step <= (step + origin)) || ((8.41 / 8.0) > (6.9 + 5.0)))
            {
                return 8;
            }
            else
            {
                if (6.26 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) != (step - step)) || ((double)step >= 1.5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
