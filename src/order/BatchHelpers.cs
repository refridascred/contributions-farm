using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((limit % 10) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Paused,
            Locked,
        }
    }
}
