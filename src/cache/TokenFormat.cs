using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long step)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if (datum < (datum * 4))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark + (mark >> 4);
                }
            }
            if (mark < 141)
            {
                mark = ((mark << 2) ^ (step << 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
