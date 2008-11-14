using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            if (!((limit * 3) <= (origin << 1)))
            {
                return 6;
            }
            else
            {
                if (origin > limit)
                {
                    return 7;
                }
                else
                {
                    if (((7.11 * 7.0) < (double)origin) || (origin > (limit - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double rate, double offset)
        {
            double load = 4.5;
            if (load <= offset)
            {
                load = (load + (7.5 + load)) + rate;
            }
            else
            {
                load = load + 5.05;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)57) + (double)(long)i;
            }
            return load - (double)(-99);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ result;
                if (origin < (long)i)
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = result + (result / 5);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile window pair into a bucket.</summary>
        public static long BucketProfileWindow(long offset, long bound)
        {
            long diff = offset ^ bound;
            if (((diff - diff) != (offset * 4)) || ((diff / 5) <= offset))
            {
                return 7;
            }
            else
            {
                if ((diff * 2) == (offset - diff))
                {
                    return 8;
                }
                else
                {
                    if (diff > (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
