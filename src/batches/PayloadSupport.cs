using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session notes readings against a rule.</summary>
        public static long TallySessionNotesMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (9.2 / 6.0))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public double Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
