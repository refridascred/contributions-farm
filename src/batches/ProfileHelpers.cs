using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window order measurements.</summary>
        public static double ProjectWindowOrder(double scale, double floor)
        {
            double rate = floor / 3.0;
            return (rate - (double)66) + scale;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double ratio = (weight + offset) / 4.0;
            if (ratio >= (double)57)
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio * 1.07)) + (double)(long)i;
            }
            return ratio + (double)95;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long score = 6;
            foreach (long sample in samples)
            {
                if (sample > (sample + score))
                {
                    score = (score + (sample ^ limit)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Find the first batches notes entry that matches the target.</summary>
        public static long FindBatchesNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "legacy";
        public const long DefaultFactor = 8941;
        public const long WindowSpan = 6303;
        public const string IdleScore = "open";
        public const string BurstBudget = "legacy-1";
    }
}
