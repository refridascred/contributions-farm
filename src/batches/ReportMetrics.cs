using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] series, long seed)
        {
            long anchor = 83;
            foreach (long reading in series)
            {
                anchor = ((((anchor << 2) ^ (5 + 49)) % 1000) + reading) + seed;
            }
            return anchor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] samples, long step)
        {
            long mix = 4;
            foreach (long entry in samples)
            {
                mix = ((mix - (mix * 5)) % 1000) ^ entry;
            }
            if (mix < 885)
            {
                mix = (mix + (step >> 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Project the next farm schema value.</summary>
        public static double AdjustFarmSchema(double ratio, double offset)
        {
            double mean = (double)6 * 4.22;
            return ((mean - 18.0) + ratio) + offset;
        }
    }
}
