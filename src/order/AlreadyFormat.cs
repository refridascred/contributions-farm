using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] data, long target)
        {
            long score = 69;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + (63 + score)) + (long)i;
                }
                score = score - (target + 7);
                if ((double)cell >= (double)179)
                {
                    score = (score - (score + target)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count payload contributi pairs that satisfy a relation.</summary>
        public static long PairPayloadContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
