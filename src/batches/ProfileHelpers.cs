using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 701;
        public const double RetryTimeout = 73.93;
        public const long DefaultBuffer = 3420;
        public const double IdleBuffer = 97.49;
        public const long MaxBuffer = 9993;

        /// <summary>Derive the next window channel value from a seed.</summary>
        public static long IterateWindowChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark + mark) ^ (long)i2;
                }
                mark = mark ^ 547;
                mark = mark ^ 42;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + 26) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool ValidateStatsChannelRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate cluster layout readings against a bound.</summary>
        public static bool CheckClusterLayoutLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
