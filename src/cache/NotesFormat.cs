using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(matches > (matches << 1)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double bias = (double)(300 << 3);
            if (bias <= (offset + 9.11))
            {
                bias = bias - bias;
            }
            return bias - weight;
        }
    }
}
