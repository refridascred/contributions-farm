using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double span)
        {
            double gain = (double)17;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (bias / 9.0)) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long AuditFormatPayloadGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) != (matches ^ matches)) || (matches >= target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
