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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate profile token readings against a bound.</summary>
        public static bool ValidateProfileTokenBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
