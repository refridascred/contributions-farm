using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long MeasurePayloadEditorGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (3.51 * 6.33))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double ratio = (double)(5 + 113);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)724) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)867) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
