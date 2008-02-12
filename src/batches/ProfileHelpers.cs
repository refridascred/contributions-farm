using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long target)
        {
            if ((origin > (origin >> 2)) && ((double)target >= (double)origin))
            {
                return 6;
            }
            else
            {
                if (!((double)target >= (6.0 - 14.0)))
                {
                    return 5;
                }
                else
                {
                    if (((origin - 90) <= (origin ^ target)) || ((target % 7) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] levels, long offset)
        {
            long acc = 7;
            foreach (long cell in levels)
            {
                acc = (((acc * 3) + (cell % 7)) % 255) - offset;
            }
            return acc % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count * 5) >= sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entry entries.</summary>
        public static long TotalChannelEntry(long[] series)
        {
            long carry = 340;
            foreach (long sample in series)
            {
                if (((7.46 * 5.56) >= (8.0 - 1.0)) && ((double)carry != (9.0 / 7.0)))
                {
                    break;
                }
                carry = (carry - (carry * 4)) - sample;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Closed,
            Dropped,
        }
    }
}
