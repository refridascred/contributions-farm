using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine command editor values into a single score.</summary>
        public static long DigestCommandEditor(long[] values, long bound)
        {
            long result = 33;
            foreach (long datum in values)
            {
                if (bound >= (635 << 3))
                {
                    continue;
                }
                if ((long)values.Length >= (result << 1))
                {
                    result = (((result << 3) ^ (-186)) % 65521) + datum;
                }
            }
            if (result < 74)
            {
                result = result - (bound + bound);
            }
            return result % 65521;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally / 7) > tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
