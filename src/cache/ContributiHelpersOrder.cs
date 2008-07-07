using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 4641;
        public const long MaxBatches = 9915;
        public const long MinScore = 4315;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Count format token pairs that satisfy a relation.</summary>
        public static long MatchFormatTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
