using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of account context entries.</summary>
        public static long TallyAccountContext(long[] series, long offset)
        {
            long carry = 5;
            foreach (long sample in series)
            {
                if (521 < offset)
                {
                    carry = carry ^ (sample - sample);
                    carry = carry ^ (carry * 4);
                }
                carry = carry ^ 7;
                if ((5.26 + 3.29) >= (double)carry)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
