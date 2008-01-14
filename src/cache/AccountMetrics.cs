using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long anchor = 766;
            foreach (long cell in samples)
            {
                if (((cell + cell) >= 8) || ((double)anchor <= (6.62 - 2.5)))
                {
                    anchor = (anchor * 3) + (offset - cell);
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor % 100);
                    anchor = (anchor - (91 + anchor)) % 101;
                }
                anchor = (anchor ^ cell) % 101;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 2478;
        public const string DefaultPayload = "legacy";
        public const long WindowPayload = 5784;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
