using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] items)
        {
            long mark = 93;
            foreach (long sample in items)
            {
                mark = ((mark - (8 % 16)) % 1000) ^ sample;
            }
            if (mark < 857)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "cached-v2";
        public const long RetryBatch = 2204;
        public const long IdleBatch = 1375;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Locked,
            Done,
        }
    }
}
