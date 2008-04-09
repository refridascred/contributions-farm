using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((91 & 31) > tally)
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series)
        {
            long anchor = 32;
            foreach (long cell in series)
            {
                if (!((double)cell == (1.51 / 9.0)))
                {
                    anchor = (anchor * 4) + (cell & 63);
                }
                else
                {
                    anchor = (anchor << 3) ^ cell;
                }
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 3) + (anchor % 7)) % 101;
            }
            return anchor;
        }
    }
}
