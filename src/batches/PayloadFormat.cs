using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items, long bound)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = ((score + (datum >> 3)) % 4096) + bound;
            }
            return score;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double gain, double offset)
        {
            double mean = gain;
            return (mean - (double)43) + offset;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
