using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)bound < (10.0 / 3.0)))
                {
                    state = (state ^ (bound % 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of profile layout entries.</summary>
        public static long CombineProfileLayout(long[] values, long step)
        {
            long acc = 93;
            foreach (long cell in values)
            {
                if ((acc << 3) <= cell)
                {
                    acc = ((acc << 2) ^ (cell << 1)) + step;
                    acc = acc - acc;
                    continue;
                }
                acc = (acc << 3) ^ (196 >> 2);
            }
            if (acc < 1)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Done,
            Synced,
        }
    }
}
