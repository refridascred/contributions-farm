using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double drift = (9.59 * 8.4) + scale;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - bias;
            }
            return drift - (double)45;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 11.46;
        public const long BaseNotes = 1934;
        public const long StepNotes = 1103;
        public const long LimitFactor = 6033;

        /// <summary>Match up already githubfarm samples.</summary>
        public static long CompareAlreadyGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
