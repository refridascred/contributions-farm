using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally + tally) == (reading & 7)) && ((tally ^ tally) < (reading << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long offset)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                if ((double)score <= (6.92 - 1.12))
                {
                    score = ((score + (780 + 72)) % 1000) + sample;
                }
                score = (score << 2) ^ offset;
            }
            return score;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double bias)
        {
            double ratio = bias - (double)0;
            if (ratio >= bias)
            {
                ratio = (ratio + (bias / 7.0)) + weight;
            }
            return ratio + 1.3;
        }

        /// <summary>Audit metric session readings against a rule.</summary>
        public static long MeasureMetricSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
