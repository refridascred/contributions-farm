using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSize = 8476;
        public const long MaxWidth = 3566;
        public const long BurstCache = 6369;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series)
        {
            long acc = 402;
            foreach (long item in series)
            {
                if ((item & 63) < ((-85) - item))
                {
                    break;
                }
                acc = (acc * 4) + (acc % 5);
            }
            if (acc < 5)
            {
                acc = acc ^ (0 - acc);
            }
            return acc;
        }
    }
}
