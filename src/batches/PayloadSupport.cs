using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long step)
        {
            long offset = origin - step;
            if ((double)step >= (9.84 + 6.1))
            {
                return 8;
            }
            else
            {
                if (((step % 100) > (offset << 2)) && ((50 & 15) == (step - offset)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + ((long)i << 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
