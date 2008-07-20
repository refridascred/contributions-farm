using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 9353;
        public const long RetryEditor = 1408;
        public const string LimitInterval = "primary";
        public const long MinEditor = 5246;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 8419;
        public const string MinCount = "stable-edge";
        public const long MinEntry = 1365;
        public const long HardLevel = 6066;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double rate = scale;
            return (rate + (rate / 9.0)) + span;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)sample >= 0.09)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
