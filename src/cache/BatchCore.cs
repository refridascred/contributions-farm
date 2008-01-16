using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many graph tools samples are out of range.</summary>
        public static long MeasureGraphToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches & 255) == (25 + reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit format channel readings against a rule.</summary>
        public static long TallyFormatChannelGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((limit * 2) <= (datum & 15)) && ((7.3 / 7.0) >= (double)datum))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheScore = 79.54;
        public const long BurstBatch = 3564;
        public const double StepBatch = 77.37;
        public const string BatchTimeout = "standard-edge";
        public const string SoftBatch = "stable-v2";
    }
}
