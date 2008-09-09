using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((552 + value) <= value)
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

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double gain, double span)
        {
            double bias = gain + (double)705;
            if (bias <= (gain + span))
            {
                bias = bias + (double)17;
            }
            return bias - bias;
        }

        /// <summary>Derive the next metric order value from a seed.</summary>
        public static long SeriesMetricOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (long)i) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
