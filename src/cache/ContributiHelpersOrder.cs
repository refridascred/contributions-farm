using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double bias = scale;
            if (bias > span)
            {
                bias = bias + (bias + span);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias * 19.0)) + (double)(long)i;
            }
            return bias + (double)11;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleFactor = 1192;
        public const long HardWindow = 1804;
        public const long StepWidth = 8865;
        public const string BatchWindow = "latest";
        public const long MinWindow = 8719;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + 808) % 65521;
                mix = mix ^ ((long)i % 10);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
