using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long AuditProfileAccountOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 3) != (floor - 51))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepDepth = "alpha-edge";
        public const string LimitScore = "alpha-edge";
        public const double MinScore = 56.62;
        public const long StepWindow = 3607;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long anchor = 5;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ reading;
                if (((anchor + anchor) <= (anchor - anchor)) && (((long)data.Length << 1) < ((-8) / 8)))
                {
                    break;
                }
            }
            if (anchor < (-910))
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a metric already value against two limits.</summary>
        public static long BucketMetricAlready(long step, long target)
        {
            if ((target + step) < (step + step))
            {
                return 8;
            }
            else
            {
                if (((step * 4) > (step + target)) && ((step >> 5) >= (target + target)))
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= (2.6 + 4.0))
                    {
                        return 1;
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
