using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4 ^ tally) > (tally >> 5))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
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
