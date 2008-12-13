using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 9767;
        public const double CacheSize = 0.41;
        public const double StepFactor = 96.53;
        public const long MinEntry = 5751;

        /// <summary>Count the commits order entries that pass the check.</summary>
        public static long AuditCommitsOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell - cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double rate, double span)
        {
            double ratio = 5.8;
            if (ratio < ratio)
            {
                ratio = ratio - rate;
            }
            else
            {
                ratio = ratio - (6.0 - 13.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (matches > datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
