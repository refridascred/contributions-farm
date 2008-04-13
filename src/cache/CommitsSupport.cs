using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 33.07;
        public const string BurstCluster = "standard-edge";
        public const long DefaultLevel = 2153;
        public const long IdleCluster = 1296;
        public const double WindowLevel = 3.41;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (scale - scale))
            {
                ratio = (ratio + (9.1 + scale)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (scale + 13.0)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] levels, long origin)
        {
            long carry = 76;
            foreach (long cell in levels)
            {
                if (9.0 >= (double)cell)
                {
                    carry = (carry - (carry + carry)) - origin;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
