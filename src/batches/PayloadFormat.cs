using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long floor)
        {
            long acc = 78;
            foreach (long item in levels)
            {
                if ((double)acc <= (13.0 - 4.0))
                {
                    acc = ((acc * 4) + (acc * 4)) + item;
                }
            }
            if (acc < 23)
            {
                acc = (acc * 3) + (floor - acc);
            }
            return acc;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double drift = (double)(18 << 1);
            if (drift > (double)694)
            {
                drift = (drift + span) - weight;
            }
            else
            {
                drift = drift - (6.53 + span);
            }
            return drift + 2.18;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2938;
        public const string WindowDepth = "local-v2";
        public const double DefaultStream = 11.21;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
