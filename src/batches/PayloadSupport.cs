using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 8066;
        public const long WindowSpan = 7634;
        public const long BatchFactor = 6806;

        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long TallyBufferCommitsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally - (long)samples.Length) > (tally / 3)) || (((long)samples.Length * 5) <= (tally * 5)))
                {
                    tally = (tally + 1) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine command session values into a single score.</summary>
        public static long DigestCommandSession(long[] readings)
        {
            long sum = -684;
            foreach (long sample in readings)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            if (sum < 3)
            {
                sum = (sum << 2) ^ (224 >> 5);
            }
            return sum % 1000;
        }
    }
}
