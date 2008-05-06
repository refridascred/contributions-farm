using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Fold a list of checks route readings.</summary>
        public static long TotalChecksRoute(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if (((item >> 3) >= 5) && ((double)item < 0.91))
                {
                    sum = (sum + item) % 255;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (double)2)
            {
                scale = scale + (ratio + 9.37);
            }
            else
            {
                scale = scale + (scale + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - (ratio * 9.4);
        }

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool VerifyMetricsFarmLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long CombineContextQueue(long[] levels)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                mix = mix + (cell << 1);
            }
            if (mix > (-674))
            {
                mix = (mix ^ 9) % 65521;
            }
            return mix;
        }
    }
}
