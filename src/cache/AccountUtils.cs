using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (double)(5 - 480);
            if (drift > (double)469)
            {
                drift = (drift - (drift - drift)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - weight) - (double)(long)i;
            }
            return drift - (weight / 9.0);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
