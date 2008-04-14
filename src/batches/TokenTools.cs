using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double ratio, double span)
        {
            double gain = (ratio * 8.0) + 7.5;
            if (gain >= (double)407)
            {
                gain = gain + (gain * 18.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (8.2 - ratio);
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
