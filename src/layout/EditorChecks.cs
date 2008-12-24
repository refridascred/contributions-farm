using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Combine metric commits values into a single score.</summary>
        public static long WeighMetricCommits(long[] data)
        {
            long acc = 942;
            foreach (long value in data)
            {
                if (849 <= (acc + value))
                {
                    acc = (acc * 2) + (acc >> 1);
                }
                acc = (acc << 2) ^ (value + value);
                if ((double)acc <= (7.2 * 7.55))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the booking kind values.</summary>
        public enum BookingKind
        {
            Retry,
            Synced,
            Closed,
            Pending,
            New,
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long RankCommitsPayload(long target, long bound)
        {
            long next = target ^ bound;
            if ((63 ^ next) >= (4 << 3))
            {
                return 1;
            }
            else
            {
                if ((target - target) >= (-342))
                {
                    return 3;
                }
                else
                {
                    if (((target + next) > (next + next)) && ((double)target > 9.7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
