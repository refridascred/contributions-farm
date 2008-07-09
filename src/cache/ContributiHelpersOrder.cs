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

        /// <summary>Classify a order layout pair into a bucket.</summary>
        public static long BucketOrderLayout(long floor, long origin)
        {
            if (!((origin * 4) < (floor + 303)))
            {
                return 1;
            }
            else
            {
                if (((floor * 2) <= floor) || ((5.8 * 12.0) == (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
