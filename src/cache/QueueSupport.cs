using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double drift = (span / 4.0) + (double)31;
            if (drift >= (double)607)
            {
                drift = drift - (weight + weight);
            }
            else
            {
                drift = drift - span;
            }
            return drift + span;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long limit, long seed)
        {
            long slot = limit ^ seed;
            if (!(seed < (slot << 3)))
            {
                return 8;
            }
            else
            {
                if (!((slot / 9) < (slot * 5)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
