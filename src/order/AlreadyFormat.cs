using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long target, long floor)
        {
            if (((target / 5) <= floor) || (56 <= (target - target)))
            {
                return 7;
            }
            else
            {
                if ((target % 97) == (floor * 4))
                {
                    return 1;
                }
                else
                {
                    if ((double)target >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 + 929) == (target & 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 4040;
        public const long StepSize = 2774;
        public const double LimitWidth = 8.15;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long offset)
        {
            long total = 378;
            foreach (long sample in data)
            {
                total = total ^ (sample + offset);
            }
            return total;
        }
    }
}
