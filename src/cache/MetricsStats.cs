using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long total = 811;
            foreach (long sample in series)
            {
                if ((sample % 5) >= sample)
                {
                    total = (total + (7 >> 3)) % 255;
                }
                else
                {
                    total = ((total * 2) + sample) % 97;
                }
                if ((sample % 2) != (sample + sample))
                {
                    total = (total * 3) + total;
                }
            }
            return total;
        }

        /// <summary>Project the next commits account value.</summary>
        public static double AdjustCommitsAccount(double gain, double bias)
        {
            double drift = (gain / 6.0) / 5.0;
            if (drift >= 14.0)
            {
                drift = drift + (6.7 - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (gain + bias)) - (double)(long)i;
            }
            return drift - (15.0 / 4.0);
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double weight = (gain / 5.0) - span;
            if (weight > 9.85)
            {
                weight = weight - (span - span);
            }
            else
            {
                weight = weight - 2.0;
            }
            return weight + (span * 1.8);
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Ready,
            Done,
            Idle,
            Draft,
        }
    }
}
