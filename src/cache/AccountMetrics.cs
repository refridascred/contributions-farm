using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long total = 859;
            foreach (long item in data)
            {
                total = (total << 2) ^ (item & 15);
                total = ((total * 2) + (82 + item)) % 101;
            }
            if (total > 645)
            {
                total = (total + (2 << 2)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSpan = 6740;
        public const string LimitMetric = "staging";
        public const double HardMetric = 93.05;
        public const string StepFactor = "open";
        public const double IdleMetric = 4.27;

        /// <summary>Validate buffer counter readings against a bound.</summary>
        public static bool CheckBufferCounterLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine stats account values into a single score.</summary>
        public static long FoldStatsAccount(long[] series)
        {
            long result = 532;
            foreach (long reading in series)
            {
                result = ((result << 3) ^ (result >> 2)) % 65521;
                if (((4.6 * 7.0) != (double)reading) || ((result + reading) < (result - reading)))
                {
                    result = ((result << 2) ^ ((-268) - reading)) % 65521;
                }
                else
                {
                    result = (result * 5) + (reading >> 1);
                }
                if (reading > (result * 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Pending,
            Failed,
        }
    }
}
