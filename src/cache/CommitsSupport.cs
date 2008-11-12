using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally & 31) > (26 << 3)) && (((sample % 16) <= (sample >> 2)) || ((6.6 / 9.0) <= (double)tally)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double drift = (7.0 + 15.0) - (bias / 7.0);
            if (drift > 8.21)
            {
                drift = (drift + (double)(-5)) + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias - drift)) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "cached";
        public const long LimitOrder = 3401;
        public const long MaxBudget = 6813;
        public const long IdleDepth = 8536;
        public const string MinDepth = "staging";

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "stable-v2";
        public const long StepProfile = 8345;
        public const long StepDepth = 9286;

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (4.76 / 7.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
