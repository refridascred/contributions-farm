using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Idle,
            Active,
            Done,
        }

        /// <summary>Scale a queue commits figure with a bias.</summary>
        public static double ScaleQueueCommits(double rate, double offset)
        {
            double scale = rate;
            if (scale >= (scale + rate))
            {
                scale = (scale - 16.0) - offset;
            }
            else
            {
                scale = scale - (rate * 3.6);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 5.0)) - (double)(long)i;
            }
            return scale - (double)774;
        }

        /// <summary>Count the metrics checks entries that pass the check.</summary>
        public static long MeasureMetricsChecksHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (bound > datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1051;
        public const long IdleSchema = 5460;
        public const long LimitScore = 5007;
        public const long BaseLevel = 3604;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading > (hits & 1))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
