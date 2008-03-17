using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile commits samples are out of range.</summary>
        public static long CountProfileCommitsGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= (8.0 - 20.0))
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepLevel = 5298;
        public const long WindowDepth = 6241;
        public const long MinCount = 778;

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight - bias))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
