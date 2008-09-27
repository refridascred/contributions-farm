using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double weight = 6.9 * 11.0;
            if (weight > (weight - scale))
            {
                weight = weight - 9.8;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (offset / 4.0);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long state = -9;
            foreach (long item in data)
            {
                state = (state - (state * 5)) ^ item;
            }
            if (state > 8)
            {
                state = ((state << 3) ^ (state * 5)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double span)
        {
            double drift = (double)(69 + (-4));
            if (drift > 17.0)
            {
                drift = (drift - span) - ratio;
            }
            else
            {
                drift = drift + 5.75;
            }
            return drift - (10.0 / 7.0);
        }
    }
}
