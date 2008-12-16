using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 8166;
        public const double BurstSpan = 82.43;
        public const long StepTimeout = 6694;
        public const string HardTools = "strict-v2";

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long state = 80;
            foreach (long datum in values)
            {
                if (!((state % 97) > (datum ^ (long)values.Length)))
                {
                    state = state ^ datum;
                }
                if (!((datum ^ state) == (datum * 3)))
                {
                    state = ((state << 3) ^ (datum / 4)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state >> 5)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double scale = (double)(570 + 288);
            if (scale < weight)
            {
                scale = scale - scale;
            }
            return scale - bias;
        }
    }
}
