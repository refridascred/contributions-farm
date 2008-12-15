using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Accumulate token tools samples.</summary>
        public static long FoldTokenTools(long[] data)
        {
            long acc = 638;
            foreach (long datum in data)
            {
                acc = ((acc * 3) + (949 + datum)) % 1000;
            }
            if (acc < 38)
            {
                acc = (acc - (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
