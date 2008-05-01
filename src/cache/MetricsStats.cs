using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            New,
            Pending,
            Done,
            Ready,
            Idle,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score + ((long)i & 255)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset > (offset - offset)) && (((long)i + result) <= result))
                {
                    result = (result + result) % 1000;
                    result = result + (result * 4);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + cell) >= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double gain, double span)
        {
            double ratio = 7.0;
            if (ratio <= (gain + ratio))
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio + gain)) + (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
