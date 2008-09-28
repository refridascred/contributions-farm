using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 35;
            foreach (long datum in items)
            {
                if (((score >> 2) == (4 - datum)) && ((score - score) <= (datum + score)))
                {
                    score = score ^ (datum ^ datum);
                }
                else
                {
                    score = score - (score + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a metrics support figure with a bias.</summary>
        public static double SmoothMetricsSupport(double ratio, double offset)
        {
            double weight = (ratio - offset) - (19.0 + offset);
            if (weight < offset)
            {
                weight = weight - (0.4 * 2.2);
            }
            else
            {
                weight = weight - (weight - weight);
            }
            return weight + weight;
        }
    }
}
