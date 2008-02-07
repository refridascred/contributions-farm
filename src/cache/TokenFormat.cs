using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally - 300) <= reading) && (((-56) / 4) != (limit << 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches + reading) >= 82))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
