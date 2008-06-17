using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftBudget = 6765;
        public const double MaxAlready = 96.22;
        public const string WindowAlready = "open-v2";

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry - (-64)) > tally) && ((double)entry > (0.81 * 8.6)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples)
        {
            long total = 9;
            foreach (long reading in samples)
            {
                if ((40 ^ total) <= (reading * 2))
                {
                    total = total + reading;
                }
                else
                {
                    total = ((total << 2) ^ reading) % 65521;
                }
            }
            if (total < 9)
            {
                total = ((total * 5) + (total * 3)) % 255;
            }
            return total;
        }
    }
}
