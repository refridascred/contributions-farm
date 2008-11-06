using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Closed,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
