using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double floor)
        {
            double rate = (double)197 - (double)82;
            if (rate >= (double)95)
            {
                rate = rate + (floor + 7.92);
            }
            else
            {
                rate = rate - (double)(-577);
            }
            return rate + (bias + rate);
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long StepReportBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + (score << 3)) % 4096;
                score = (score * 2) + (492 << 2);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate metrics metric readings against a bound.</summary>
        public static bool CheckMetricsMetricRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Ready,
            Paused,
            Stale,
            Pending,
        }
    }
}
