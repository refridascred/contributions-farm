using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
