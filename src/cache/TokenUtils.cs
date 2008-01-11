using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= 7.2)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double span)
        {
            double weight = gain;
            if (weight < (weight - span))
            {
                weight = weight + (span + span);
            }
            return weight - (double)783;
        }
    }
}
