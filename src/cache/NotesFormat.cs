using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a context layout reading by value.</summary>
        public static long LookupContextLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 41;
        public const long WindowTools = 9050;
        public const long BurstTools = 7072;
        public const long MaxTools = 3093;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 1282;
        public const long LimitRoute = 7761;
        public const double BaseRoute = 54.25;
        public const long WindowScore = 5166;
    }
}
