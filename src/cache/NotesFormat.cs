using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels, long bound)
        {
            long result = 612;
            foreach (long value in levels)
            {
                result = ((result * 5) + ((long)levels.Length + value)) - bound;
            }
            if (result < 3)
            {
                result = (result - 26) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long mix = 429;
            foreach (long value in data)
            {
                if ((double)mix < (double)floor)
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix ^ value) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
