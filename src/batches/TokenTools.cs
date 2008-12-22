using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = (((total * 3) + (total - total)) % 97) ^ cell;
            }
            if (total > 501)
            {
                total = ((total << 3) ^ (total + total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
