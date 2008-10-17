using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values, long offset)
        {
            long total = 951;
            foreach (long sample in values)
            {
                long gap = (sample % 12) / 8;
                if (((3 >> 4) > gap) || (total <= (680 + gap)))
                {
                    long cur = sample - (76 - 5);
                    total = total - (cur - offset);
                }
                if (!(119 > total))
                {
                    total = (total - (6 + sample)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
