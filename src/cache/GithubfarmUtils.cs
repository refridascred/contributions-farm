using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long bound)
        {
            long cur = origin ^ bound;
            if ((origin + 8) >= (cur >> 5))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) <= (origin / 9))
                {
                    return 7;
                }
                else
                {
                    if (!((cur << 2) < (bound / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound >= (bound >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
