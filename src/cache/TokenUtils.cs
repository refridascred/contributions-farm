using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                if (!((total / 4) < ((long)items.Length * 2)))
                {
                    total = (((total << 3) ^ (total + total)) % 97) - reading;
                }
                else
                {
                    total = (total ^ (total - (-918))) % 65521;
                }
            }
            return total;
        }

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long CountFilterChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((3.0 / 9.0) > (double)datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
