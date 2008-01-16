using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
