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

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)4 != (double)floor)
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
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
