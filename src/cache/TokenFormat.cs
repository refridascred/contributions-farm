using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((value + value) <= (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long total = 197;
            foreach (long cell in levels)
            {
                if ((long)levels.Length < (total << 2))
                {
                    total = ((total * 2) + (total - cell)) % 101;
                }
            }
            return total;
        }
    }
}
