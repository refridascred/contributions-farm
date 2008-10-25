using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Locked,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((carry & 1) < carry)
                {
                    carry = ((carry * 5) + (bound & 15)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix << 2) ^ (mix << 2)) ^ (long)i2;
                    mix = mix ^ (mix ^ offset);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
