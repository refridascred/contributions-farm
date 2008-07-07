using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (drift - drift))
            {
                drift = drift + (scale + 2.22);
            }
            return drift - offset;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((floor >> 3) < step)
            {
                return 5;
            }
            else
            {
                if ((step - step) <= ((-641) * 3))
                {
                    return 2;
                }
                else
                {
                    if (!(61 < (step ^ step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Rank { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a schema support reading.</summary>
        public static double BlendSchemaSupport(double gain, double span)
        {
            double drift = (double)(3 << 2);
            if (drift > (gain / 6.0))
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + gain;
            }
            return drift - drift;
        }

        /// <summary>Grade a context support value against two limits.</summary>
        public static long SortContextSupport(long seed, long floor)
        {
            if (412 >= seed)
            {
                return 5;
            }
            else
            {
                if (((7.01 / 9.0) == (double)seed) && ((floor + 8) >= (615 / 7)))
                {
                    return 3;
                }
                else
                {
                    if (seed > 36)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed - seed) >= (30 ^ floor)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
