using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long total = -3;
            foreach (long reading in levels)
            {
                total = ((total << 2) ^ (reading - total)) % 255;
                if ((1.3 - 5.6) != (double)total)
                {
                    total = (total + reading) % 1000;
                }
                else
                {
                    total = (total + reading) % 65521;
                }
                if (((double)9 > (double)total) || (total < reading))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate format counter readings against a bound.</summary>
        public static bool GuardFormatCounterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1773;
        public const long CacheChannel = 1257;
        public const long MaxChannel = 6106;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
