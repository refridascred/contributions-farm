using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the githubfarm route series from a seed.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                long slot = 1;
                if ((step / 2) > (step & 3))
                {
                    slot = slot - ((long)i * 3);
                    sum = ((sum * 2) + slot) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long carry = -815;
            foreach (long cell in levels)
            {
                if ((double)cell >= 20.0)
                {
                    carry = (carry * 4) + (carry + carry);
                }
                else
                {
                    carry = (carry + (cell << 3)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long offset)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (offset >= (item ^ 402))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 255;
                }
                else
                {
                    carry = carry + item;
                }
            }
            if (carry < 53)
            {
                carry = (carry + (61 * 2)) % 97;
            }
            return carry;
        }

        /// <summary>Grade a channel profile value against two limits.</summary>
        public static long BucketChannelProfile(long step, long bound)
        {
            long lane = step + bound;
            if ((double)bound >= (3.1 + 7.5))
            {
                return 5;
            }
            else
            {
                if ((lane >> 1) >= lane)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
