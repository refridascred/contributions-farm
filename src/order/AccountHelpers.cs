using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long AuditEntryGraphMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((target ^ (-1)) < (target - tally))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = (acc << 3) ^ (acc % 97);
                acc = ((acc << 3) ^ (value - 269)) % 4096;
                acc = ((acc << 2) ^ (acc + acc)) % 65521;
            }
            return acc;
        }
    }
}
