using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            New,
            Queued,
            Done,
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

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long carry = 0;
            foreach (long entry in items)
            {
                if ((double)carry != (8.4 - 9.8))
                {
                    carry = ((carry ^ carry) % 255) ^ entry;
                }
                if (carry < (233 % 7))
                {
                    carry = (carry * 2) + (-911);
                }
            }
            return carry;
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
