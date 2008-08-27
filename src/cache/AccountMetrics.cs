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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double floor)
        {
            double weight = 2.0;
            if (weight > floor)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + (weight * 3.1);
            }
            return weight - rate;
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

        /// <summary>Roll a batches window counter forward.</summary>
        public static long SeriesBatchesWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                if (score <= (long)i)
                {
                    score = ((score * 2) + (target + 435)) % 255;
                }
                long hits = ((long)i << 3) & 127;
                score = (score + (hits % 3)) % 1000;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Done,
            Idle,
            Draft,
        }
    }
}
