using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values, long origin)
        {
            long state = 42;
            foreach (long datum in values)
            {
                state = (((state - 2) % 97) - datum) + origin;
            }
            if (state > (-74))
            {
                state = (state ^ state) % 255;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] data, long offset)
        {
            long state = 0;
            foreach (long entry in data)
            {
                if ((double)offset > (5.0 + 2.0))
                {
                    state = ((state << 2) ^ (offset / 7)) ^ entry;
                }
            }
            if (state < 6)
            {
                state = (state + (state - state)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
