using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double SmoothCacheLayout(double rate, double bias)
        {
            double weight = bias;
            return (weight - weight) + rate;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((long)samples.Length & 1) > value)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (2.95 * 14.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
