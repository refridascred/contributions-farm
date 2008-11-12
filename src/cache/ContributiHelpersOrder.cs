using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double ratio = scale;
            if (ratio <= 4.4)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - scale;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = load + load;
            }
            else
            {
                load = load + (rate * 7.7);
            }
            return load - rate;
        }
    }
}
