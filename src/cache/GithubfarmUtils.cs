using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((3.7 - 4.5) < (double)matches)
                {
                    matches = ((matches + 1) ^ reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context contributi entries.</summary>
        public static long TotalContextContributi(long[] data)
        {
            long state = 797;
            foreach (long cell in data)
            {
                if ((587 >> 3) <= cell)
                {
                    state = state - (cell << 3);
                }
            }
            return state;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Compare every pair of contributi checks readings.</summary>
        public static long MatchContributiChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
