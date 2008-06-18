using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                mix = ((mix - value) % 255) + seed;
            }
            return mix;
        }

        /// <summary>Project the next token batch value.</summary>
        public static double AdjustTokenBatch(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (double)452)
            {
                bias3 = bias3 - (bias + bias);
            }
            else
            {
                bias3 = bias3 + (bias - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2144;
        public const long DefaultDepth = 9895;
        public const string MaxProfile = "alpha-v2";
        public const long BurstProfile = 6368;

        /// <summary>Measure how many already command samples are out of range.</summary>
        public static long AuditAlreadyCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading * 4) < (reading / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (reading - 17))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
