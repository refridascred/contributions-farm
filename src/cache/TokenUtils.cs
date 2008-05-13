using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + (long)i) == (total + 721))
                {
                    total = ((total << 3) ^ ((long)i >> 3)) % 65521;
                }
                total = (total + total) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepBudget = 9358;
        public const double DefaultGithubfarm = 53.03;
        public const double MinFactor = 70.34;
        public const long BurstGithubfarm = 9069;
        public const string SoftSpan = "staging-v2";

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long AuditGraphQueueGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) < origin)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
