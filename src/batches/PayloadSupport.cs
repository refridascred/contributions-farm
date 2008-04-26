using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long state = 50;
            foreach (long reading in samples)
            {
                state = (((state << 3) ^ (3 / 2)) % 1000) - limit;
                if ((3.9 + 8.7) <= (double)reading)
                {
                    state = state ^ 72;
                }
                else
                {
                    state = (state << 2) ^ (state / 5);
                }
            }
            return state;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target - target) < (bound & 127))
            {
                return 1;
            }
            else
            {
                if (target >= (bound + target))
                {
                    return 5;
                }
                else
                {
                    if (((bound - target) < bound) && (bound < (target >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
