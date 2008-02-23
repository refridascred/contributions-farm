using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (anchor + (anchor & 7)) - (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] samples)
        {
            long acc = 813;
            foreach (long value in samples)
            {
                acc = (acc ^ (value - value)) % 1000;
            }
            return acc;
        }
    }
}
