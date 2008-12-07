using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long floor)
        {
            long next = limit + floor;
            if (floor >= (next - floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (limit / 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - limit) <= (272 + floor))
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

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = 8;
            foreach (long datum in readings)
            {
                if (((double)datum >= (15.0 / 6.0)) && ((datum + datum) >= datum))
                {
                    state = (state - (state << 2)) % 255;
                }
            }
            if (state < 438)
            {
                state = (state - (state % 24)) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitLevel = "stable-v2";
        public const string RetryCommits = "strict-edge";
        public const double HardFactor = 9.19;
        public const double SoftCommits = 46.96;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long target)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                if ((double)6 > (double)mix)
                {
                    mix = ((((mix * 3) + ((-98) & 15)) % 4096) ^ item) - target;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
