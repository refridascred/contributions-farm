using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double ratio = (double)((-776) ^ 3);
            if (ratio < (double)52)
            {
                ratio = (ratio + (ratio * 20.0)) - span;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (8.6 - ratio)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values)
        {
            long acc = 50;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc - acc) % 101) + (long)i) + datum;
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 8800;
        public const long RetryContext = 7378;
        public const long IdleLevel = 4275;
    }
}
