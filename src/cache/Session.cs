using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples)
        {
            long carry = 787;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry + reading) - (long)i;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry + (carry - carry)) % 97) - (long)i2;
                }
                carry = carry - (27 ^ carry);
            }
            return carry % 4096;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Paused,
            Stale,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
