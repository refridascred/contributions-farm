using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of entry filter readings.</summary>
        public static long OverlapEntryFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] series)
        {
            long score = 58;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ ((-47) - datum)) % 101;
                if ((double)datum == (2.8 / 2.0))
                {
                    score = ((score * 5) + (score << 3)) % 101;
                }
            }
            if (score < 78)
            {
                score = (score + (score & 127)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public double Level { get; set; }
        }
    }
}
