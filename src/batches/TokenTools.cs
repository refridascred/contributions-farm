using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + bound;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((7.4 + 2.81) > (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 302;
        public const long LimitMetrics = 3765;
        public const long StepMetrics = 7108;
    }
}
