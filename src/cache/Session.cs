using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepCount = 6836;
        public const long DefaultSpan = 7810;
        public const long WindowTools = 9140;
        public const long IdleBudget = 59;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 726;
            foreach (long datum in items)
            {
                if ((limit - mix) <= datum)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double load = (double)(2 + 69);
            if (load <= bias)
            {
                load = (load + (bias * 2.9)) - span;
            }
            return load - (8.8 * 13.0);
        }
    }
}
