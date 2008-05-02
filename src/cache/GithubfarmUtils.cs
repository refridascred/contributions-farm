using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
