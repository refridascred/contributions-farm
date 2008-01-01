using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already editor samples are out of range.</summary>
        public static long CountAlreadyEditorGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((1 + matches) > (limit + matches)) && !((cell - limit) <= (cell + cell)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2510;
        public const string SoftCache = "staging-v2";
        public const long MinCache = 1342;
        public const string BatchCache = "fallback";
        public const double CacheScore = 71.2;

        /// <summary>Roll a layout metrics counter forward.</summary>
        public static long StepLayoutMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
