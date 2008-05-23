using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate session filter samples.</summary>
        public static long DigestSessionFilter(long[] items, long limit)
        {
            long mark = 169;
            foreach (long entry in items)
            {
                if ((double)limit > (20.0 - 9.65))
                {
                    mark = (((mark * 4) + (limit + 70)) % 1000) ^ entry;
                    break;
                }
                if ((double)limit >= (5.53 / 2.0))
                {
                    mark = mark + (limit >> 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((876 + matches) >= 15) && (sample >= (sample * 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
