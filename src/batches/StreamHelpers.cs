using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryFactor = 2823;
        public const long BurstLevel = 1521;
        public const double MinLevel = 7.37;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long BucketEntryAccount(long target, long floor)
        {
            if ((6 + floor) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) < floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)target < (double)287) || ((floor << 1) == (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 <= (floor + floor)) && ((target % 97) >= (floor % 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
