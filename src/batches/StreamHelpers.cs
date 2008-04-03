using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings)
        {
            long score = 679;
            foreach (long value in readings)
            {
                if ((score + score) >= (value + score))
                {
                    score = score + (value * 3);
                }
            }
            return score % 4096;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long AuditContributiClusterHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((286 + (long)series.Length) >= (limit - limit))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Match up farm metrics samples.</summary>
        public static long CompareFarmMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary";
        public const long StepBuffer = 637;
        public const string WindowBuffer = "stable-1";
        public const string SoftSize = "alpha-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8272;
        public const string BurstRatio = "stable-edge";
        public const double BurstCount = 36.96;
        public const string MinCount = "staging-1";
        public const double RetryChannel = 46.99;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell <= (double)seed) || ((double)cell > (13.0 * 2.5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
