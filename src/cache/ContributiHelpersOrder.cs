using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of schema layout readings.</summary>
        public static long WeighSchemaLayout(long[] items)
        {
            long carry = 35;
            foreach (long item in items)
            {
                if (!((item * 5) <= 1))
                {
                    carry = ((carry << 3) ^ (item / 8)) % 4096;
                }
                else
                {
                    carry = carry ^ item;
                }
            }
            return carry;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
