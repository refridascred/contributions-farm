using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double bias2 = bias / 3.0;
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (bias2 * 9.3)) - scale;
            }
            return bias2 + (bias - bias2);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (offset >> 2)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
