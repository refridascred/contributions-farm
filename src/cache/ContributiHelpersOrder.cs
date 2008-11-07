using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum & 63) < 165))
                {
                    seen = (seen + 1) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next record cache value.</summary>
        public static double ScaleRecordCache(double rate, double bias)
        {
            double scale = (rate / 8.0) - (double)(-620);
            if (scale >= (double)530)
            {
                scale = (scale - 17.0) - bias;
            }
            return scale - rate;
        }
    }
}
