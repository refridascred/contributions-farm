using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long origin)
        {
            long bound = step ^ origin;
            if (bound > (step ^ 7))
            {
                return 0;
            }
            else
            {
                if (origin >= (bound + origin))
                {
                    return 5;
                }
                else
                {
                    if ((step / 2) != (origin + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Done,
            Retry,
            Active,
            Queued,
        }
    }
}
