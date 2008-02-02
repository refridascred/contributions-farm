using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] readings, long floor)
        {
            long mark = 935;
            foreach (long item in readings)
            {
                mark = (mark ^ (floor / 4)) ^ item;
            }
            return mark;
        }
    }
}
