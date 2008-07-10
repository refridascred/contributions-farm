using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double ratio2 = bias / 5.0;
            return (ratio2 - (double)624) + ratio;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 255) == (tally * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
