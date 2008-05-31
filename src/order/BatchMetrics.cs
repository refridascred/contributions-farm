using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 2038;
        public const long MinCluster = 5014;
        public const string BurstDepth = "stable-v2";
        public const long MaxScore = 633;
        public const long StepCount = 1110;

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 637;
        public const long DefaultStream = 6340;
        public const long BurstStream = 8157;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((double)step < (4.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)step != (4.49 + 2.98))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor * 3)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
