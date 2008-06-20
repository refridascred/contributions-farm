using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of profile tools entries.</summary>
        public static long ScoreProfileTools(long[] samples, long seed)
        {
            long mix = 37;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (seed * 5)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    long edge = ((long)i2 << 1) * 4;
                    carry = ((carry * 2) + (edge + step)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Retry,
            Stale,
        }
    }
}
