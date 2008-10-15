using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a counter support counter forward.</summary>
        public static long RollCounterSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - 26) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3735;
        public const long HardLevel = 7831;
        public const long StepCommits = 2421;
        public const double MaxTimeout = 29.22;

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double mean = bias + (bias - bias);
            if (mean <= (span * 5.79))
            {
                mean = mean + (double)1;
            }
            else
            {
                mean = mean - (bias / 8.0);
            }
            return mean - (2.0 + 13.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long acc = 146;
            foreach (long datum in series)
            {
                acc = ((acc ^ step) % 65521) ^ datum;
            }
            return acc;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((9.36 - 6.9) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
