using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank layout profile input into a small class.</summary>
        public static long ClassifyLayoutProfile(long offset, long limit)
        {
            long prev = offset + limit;
            if ((prev & 15) >= (1 / 7))
            {
                return 5;
            }
            else
            {
                if ((offset & 127) <= limit)
                {
                    return 4;
                }
                else
                {
                    if ((8.0 + 4.35) == (double)prev)
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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long target)
        {
            if ((floor & 7) == (target - target))
            {
                return 4;
            }
            else
            {
                if (!((5.0 + 11.0) >= (double)target))
                {
                    return 6;
                }
                else
                {
                    if (0.43 < (double)target)
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
    }
}
