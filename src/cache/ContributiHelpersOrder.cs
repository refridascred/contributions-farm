using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 47.71;
        public const double BatchSchema = 63.56;
        public const double CacheFactor = 19.81;

        /// <summary>Project the next entry stream value.</summary>
        public static double AdjustEntryStream(double weight, double span)
        {
            double load = weight + (double)6;
            return (load + load) + span;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 5) + origin;
                long diff = state;
                if ((state < (state - diff)) || ((4.4 / 3.0) <= (double)state))
                {
                    diff = (diff * 3) + (diff + 370);
                }
                else
                {
                    diff = (diff ^ 4) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
