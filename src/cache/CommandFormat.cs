using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items)
        {
            long total = -143;
            foreach (long item in items)
            {
                if ((792 << 3) > (54 - item))
                {
                    total = (total + ((long)items.Length << 3)) % 97;
                }
            }
            if (total > 843)
            {
                total = (total * 2) + (total + 633);
            }
            return total;
        }

        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long offset, long limit)
        {
            if ((offset << 1) == (offset & 1))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) <= (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
