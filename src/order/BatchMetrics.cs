using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double rate = (double)((-3) - 4);
            if (rate <= (bias + rate))
            {
                rate = (rate + (double)1) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (rate + 4.1);
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long seed)
        {
            long delta = origin + seed;
            if (((delta - seed) > 865) && ((double)origin != (9.0 - 7.2)))
            {
                return 4;
            }
            else
            {
                if (((0 ^ delta) <= origin) && ((3 << 3) >= (seed - seed)))
                {
                    return 2;
                }
                else
                {
                    if (((seed * 4) < (origin << 1)) && ((seed % 2) >= (199 ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long anchor = 24;
            foreach (long cell in readings)
            {
                if ((47 - (long)readings.Length) <= anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor >> 2)) % 101) ^ cell;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)readings.Length) % 255;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor >> 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Draft,
            Paused,
            Retry,
        }
    }
}
