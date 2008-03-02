using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long total = 939;
            foreach (long value in data)
            {
                total = (((total * 2) + (total & 127)) % 1000) - value;
            }
            return total % 97;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 2) < (item >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
