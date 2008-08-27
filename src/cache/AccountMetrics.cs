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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double rate = (double)(149 % 16);
            return ((rate + (double)827) + bias) + span;
        }
    }
}
