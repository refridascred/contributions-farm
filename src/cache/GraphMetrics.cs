using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepBudget = 257;
        public const long RetryTimeout = 5188;
        public const long MinDepth = 370;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4 << 1) > matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (double)7 + (bias - bias);
            if (drift >= offset)
            {
                drift = drift + (double)80;
            }
            return drift - offset;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
