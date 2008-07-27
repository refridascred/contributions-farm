using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double span)
        {
            double gain = (rate * 0.48) + (double)42;
            if (gain <= 16.0)
            {
                gain = (gain - gain) - span;
            }
            return gain + (gain - rate);
        }

        /// <summary>Audit contributi record readings against a rule.</summary>
        public static long MeasureContributiRecordHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches + sample) >= (sample - (-519)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (473 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
