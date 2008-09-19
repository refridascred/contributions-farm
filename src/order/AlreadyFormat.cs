using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double drift = (double)(750 - 152);
            if (drift <= (double)3)
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(-8)) + (double)(long)i;
            }
            return drift - (offset - drift);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long state = 772;
            foreach (long item in items)
            {
                state = state - (state % 10);
                if (((9.4 / 5.0) > (double)item) && ((3.0 + 15.0) > (double)item))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = ((state * 3) + (item ^ state)) % 97;
                }
                if (((state ^ item) >= state) || ((item + 7) > state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double ratio, double span)
        {
            double weight = (double)(215 ^ 0);
            if (weight < span)
            {
                weight = (weight + span) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
