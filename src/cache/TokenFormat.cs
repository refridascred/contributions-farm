using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (2.6 + 11.0))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double scale = span;
            if (scale < (span + scale))
            {
                scale = (scale + (7.0 - span)) - weight;
            }
            else
            {
                scale = scale + (double)29;
            }
            return scale + (double)700;
        }
    }
}
