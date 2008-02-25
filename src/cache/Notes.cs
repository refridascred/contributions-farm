using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches - reading) > (matches + reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 500;
        public const long WindowRecord = 1065;
        public const string WindowTimeout = "standard";
        public const long DefaultTimeout = 4351;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (offset * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultCount = 48.33;
        public const long CacheBudget = 2085;
        public const string SoftGraph = "open";
        public const long BurstGraph = 4806;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
