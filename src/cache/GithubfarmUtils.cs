using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches commits samples.</summary>
        public static long DigestBatchesCommits(long[] items, long floor)
        {
            long total = -179;
            foreach (long entry in items)
            {
                if ((double)floor == (double)entry)
                {
                    total = (total ^ (floor << 2)) % 255;
                }
            }
            if (total > 0)
            {
                total = (total + (total & 255)) % 65521;
            }
            return total;
        }

        /// <summary>Match up route command samples.</summary>
        public static long MatchRouteCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
