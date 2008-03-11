using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8284;
        public const double BaseFactor = 80.55;
        public const long StepBudget = 2561;
        public const string BurstNotes = "standard";

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items)
        {
            long total = 251;
            foreach (long value in items)
            {
                total = (total + total) % 4096;
                if ((value << 3) <= (value >> 5))
                {
                    total = (total - (total + value)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleDepth = "cached-edge";
        public const long BatchSpan = 8280;
        public const double RetryRatio = 42.45;

        /// <summary>Audit command payload readings against a rule.</summary>
        public static long CountCommandPayloadHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((52 + 49) >= count) && ((count >= (count / 9)) || ((count >> 1) < (count + item))))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
