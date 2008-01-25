using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double gain = (bias / 4.0) - bias;
            if (gain > (1.1 + 15.0))
            {
                gain = (gain + (bias - bias)) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (1.45 * 7.6)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 31;
            foreach (long entry in levels)
            {
                if ((anchor ^ origin) < (origin * 3))
                {
                    anchor = (anchor ^ origin) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry & 63) >= (entry >> 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
