using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long anchor = 8;
            foreach (long entry in values)
            {
                anchor = ((anchor << 2) ^ (entry ^ 44)) % 4096;
                if ((entry * 3) <= (entry - entry))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
                anchor = (anchor + (anchor - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
