using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (acc < (item + item))
                {
                    acc = ((acc * 3) + (acc / 2)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = ((acc * 5) + (acc * 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Digest a series of buffer graph entries.</summary>
        public static long ScoreBufferGraph(long[] values)
        {
            long mark = -35;
            foreach (long entry in values)
            {
                if ((972 << 1) == (entry & 7))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 4096;
                }
                else
                {
                    mark = (mark ^ (entry >> 1)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Active,
            Idle,
        }
    }
}
