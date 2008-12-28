using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string StepWidth = "standard";
        public const long CacheMetric = 7095;
        public const long BaseMetric = 5627;
        public const double StepMetric = 45.13;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((4.5 * 18.0) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up token route samples.</summary>
        public static long CompareTokenRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
