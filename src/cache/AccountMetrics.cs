using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every order checks entry stays within the limit.</summary>
        public static bool ValidateOrderChecksLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long origin)
        {
            long cur = target ^ origin;
            if ((double)target != (double)origin)
            {
                return 2;
            }
            else
            {
                if (((origin - cur) >= (target & 127)) && (80 <= (cur ^ origin)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long seed, long origin)
        {
            if (origin >= (seed - 58))
            {
                return 0;
            }
            else
            {
                if ((double)origin < (4.4 * 1.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 4) == (seed ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(83 <= seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
