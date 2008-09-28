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

        /// <summary>Audit session contributi readings against a rule.</summary>
        public static long TallySessionContributiMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((-788) + entry) > 1))
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
