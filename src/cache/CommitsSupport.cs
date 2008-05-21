using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long origin)
        {
            long prev = bound - origin;
            if ((bound % 100) <= (prev - bound))
            {
                return 1;
            }
            else
            {
                if ((48 + bound) > (prev / 3))
                {
                    return 7;
                }
                else
                {
                    if (((14.0 + 9.4) == (double)prev) && (origin <= (198 + 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin > (99 >> 2)) || ((prev + origin) >= (prev + prev)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if ((17 >> 1) <= (limit % 100))
            {
                return 8;
            }
            else
            {
                if (((8 - limit) <= (limit2 + (-7))) || ((-4) >= limit2))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (7.82 - 5.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) == (865 + limit2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a contributi checks reading.</summary>
        public static double AdjustContributiChecks(double gain, double span)
        {
            double mean = (gain - 3.7) * 3.3;
            if (mean > (gain / 3.0))
            {
                mean = (mean + 4.12) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + 9.2) - (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
