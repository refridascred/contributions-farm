using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (datum <= (tally % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double bias, double span)
        {
            double ratio = bias + bias;
            if (ratio <= (span / 2.0))
            {
                ratio = ratio - (bias / 5.0);
            }
            else
            {
                ratio = ratio + (7.07 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (ratio * 5.71)) + (double)(long)i;
            }
            return ratio + (ratio * 1.04);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
