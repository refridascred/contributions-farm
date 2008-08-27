using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLevel = 2979;
        public const long BatchLayout = 8598;
        public const long BaseLevel = 9613;
        public const long StepLayout = 8254;
        public const long MinLayout = 2155;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items, long floor)
        {
            long score = -116;
            foreach (long cell in items)
            {
                score = (score - (score ^ cell)) - floor;
                if ((score >= cell) && ((cell ^ cell) >= (81 / 6)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double rate = (double)(149 % 16);
            return ((rate + (double)827) + bias) + span;
        }
    }
}
