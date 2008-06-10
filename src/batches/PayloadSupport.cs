using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (total < (entry % 8))
                {
                    total = (total - (entry + 62)) % 101;
                }
                else
                {
                    total = (total - (total ^ origin)) % 1000;
                }
            }
            if (total < (-67))
            {
                total = ((total * 5) + 6) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
