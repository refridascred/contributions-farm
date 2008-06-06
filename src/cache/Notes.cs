using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((12 + 7) > seen) && ((seen + seen) < ((-72) << 2))) && ((double)seen < (double)sample))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double span)
        {
            double load = span;
            if (load < gain)
            {
                load = load + load;
            }
            return load + span;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long step)
        {
            if (limit < step)
            {
                return 0;
            }
            else
            {
                if (((8.0 - 1.8) > (double)limit) || ((4.3 / 2.0) < (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            long bound2 = offset ^ bound;
            if ((4 >= offset) || ((offset << 3) > offset))
            {
                return 0;
            }
            else
            {
                if ((bound2 >> 1) <= bound2)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
