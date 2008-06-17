using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample - 3) >= (bound << 2)) || ((tally >> 1) > bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long ScoreTokenOrder(long[] readings)
        {
            long mark = 596;
            foreach (long entry in readings)
            {
                if ((mark % 7) != (mark - entry))
                {
                    mark = (mark ^ 0) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
