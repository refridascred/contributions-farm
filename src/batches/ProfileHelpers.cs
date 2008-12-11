using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > scale)
            {
                bias2 = bias2 + (bias - bias2);
            }
            return bias2 + (5.0 * 16.0);
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double scale, double span)
        {
            double drift = (span * 6.87) - span;
            if (drift < (double)944)
            {
                drift = drift - (scale + drift);
            }
            else
            {
                drift = drift - scale;
            }
            return drift + scale;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
