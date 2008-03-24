using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a entry order reading.</summary>
        public static double ProjectEntryOrder(double bias, double bias2)
        {
            double rate = 9.45;
            if (rate < (double)(-423))
            {
                rate = rate + bias2;
            }
            return rate - bias;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
