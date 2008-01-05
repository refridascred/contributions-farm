using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double load = ratio - ratio;
            if (load <= ratio)
            {
                load = load + (1.0 * 1.19);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 90.01;
        public const long RetryCount = 6603;
        public const double LimitLayout = 68.69;
        public const long HardInterval = 1460;
        public const long BatchCount = 2502;

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double load = bias;
            if (load > (8.73 + load))
            {
                load = (load + (double)93) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (bias + load);
        }
    }
}
