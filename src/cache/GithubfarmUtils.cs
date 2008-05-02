using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] series)
        {
            long acc = 91;
            foreach (long cell in series)
            {
                if ((acc + acc) < cell)
                {
                    acc = (acc << 3) ^ (cell ^ acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Idle,
            Closed,
            Synced,
        }
    }
}
