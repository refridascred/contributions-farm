using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                long edge = ((-537) * 4) - (369 + target);
                anchor = (anchor ^ (anchor % 5)) % 4096;
                anchor = (anchor + (edge + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((bound + bound) > (target - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((14.0 + 3.9) > (double)item) && (((item >> 5) != (item - item)) || ((8.0 / 7.0) < (double)step)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
