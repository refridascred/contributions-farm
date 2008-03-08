using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((5.0 / 3.0) >= (double)reading) && ((tally + reading) <= ((-892) << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total - total)) % 1000;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
