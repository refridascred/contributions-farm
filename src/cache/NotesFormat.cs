using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long offset)
        {
            long total = 210;
            foreach (long datum in items)
            {
                total = ((total - (datum / 6)) % 65521) - offset;
                total = total - ((-75) + datum);
                if ((double)total > (8.14 + 9.43))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Scale a buffer window figure with a bias.</summary>
        public static double AdjustBufferWindow(double gain, double offset)
        {
            double mean = 8.0;
            if (mean < (5.12 * 9.99))
            {
                mean = ((mean + 6.0) - gain) - offset;
            }
            return mean - mean;
        }
    }
}
