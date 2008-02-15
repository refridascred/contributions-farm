using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long AuditOrderAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches >= (datum >> 4)) || (880 <= (datum - matches))) && (((datum + matches) < (matches & 15)) || ((matches - 48) > 502)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally >> 5) >= (offset - tally))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
