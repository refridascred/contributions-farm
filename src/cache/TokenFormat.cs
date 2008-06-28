using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes session figure with a bias.</summary>
        public static double SmoothNotesSession(double bias, double offset)
        {
            double load = (double)(16 << 3);
            return ((load + (double)51) + bias) + offset;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
