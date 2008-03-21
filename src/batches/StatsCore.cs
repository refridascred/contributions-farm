using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long target, long step)
        {
            if ((step - target) < target)
            {
                return 0;
            }
            else
            {
                if ((6.8 - 5.33) < (double)step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up channel entry samples.</summary>
        public static long OverlapChannelEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cluster order pair into a bucket.</summary>
        public static long SortClusterOrder(long seed, long seed2)
        {
            long offset = seed - seed2;
            if ((offset - seed) < seed2)
            {
                return 1;
            }
            else
            {
                if (((seed + seed2) < (27 ^ 307)) && ((offset >> 1) < seed2))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
