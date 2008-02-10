using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool VerifyProfileRouteBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the session editor series from a seed.</summary>
        public static long DeriveSessionEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((step * 3) <= (step ^ step)))
                {
                    acc = (acc * 2) + (-680);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long GradeReportSupport(long bound, long floor)
        {
            if (!((floor + floor) >= floor))
            {
                return 0;
            }
            else
            {
                if (((floor >> 5) > floor) || ((8.0 - 14.0) < (7.09 - 11.0)))
                {
                    return 3;
                }
                else
                {
                    if (3.1 > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long MatchOrderBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long limit)
        {
            long offset = floor - limit;
            if ((1 & 255) < (62 + offset))
            {
                return 5;
            }
            else
            {
                if ((0 - 86) > offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
