using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally >= 786)
                {
                    tally = ((tally + 1) ^ datum) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = 319;
            foreach (long reading in levels)
            {
                acc = ((acc + (step ^ 15)) % 101) - reading;
            }
            if (acc < 8)
            {
                acc = (acc ^ step) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Done,
            Active,
        }
    }
}
