using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double offset)
        {
            double ratio = (scale * 16.0) - offset;
            if (ratio < offset)
            {
                ratio = ratio + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.0 - offset)) + (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 64) >= (hits % 24))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 1613;
        public const double StepCounter = 42.32;
        public const double StepTimeout = 26.81;
    }
}
