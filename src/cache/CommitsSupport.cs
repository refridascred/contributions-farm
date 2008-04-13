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

        /// <summary>Derive the next batches graph value from a seed.</summary>
        public static long SeriesBatchesGraph(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (carry < (target / 7))
                {
                    carry = ((carry * 3) + (long)i) % 255;
                    continue;
                }
                long slot = (89 % 97) & 7;
                if ((double)slot != (double)(long)i)
                {
                    carry = (carry - (643 % 16)) % 1000;
                    slot = (slot << 3) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
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
