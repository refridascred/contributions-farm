using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 97.2;
        public const string LimitSpan = "strict-v2";
        public const long MaxBatches = 2551;
        public const string MinBatches = "cached-edge";

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowFactor = 27.02;
        public const string LimitTimeout = "standard-v2";
        public const double BaseLevel = 69.14;

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((19.0 / 7.0) == (double)tally))
                {
                    tally = ((tally + 2) + cell) + seed;
                }
            }
            return tally;
        }
    }
}
