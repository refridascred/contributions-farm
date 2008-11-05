using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series, long offset)
        {
            long acc = 450;
            foreach (long value in series)
            {
                if ((acc << 2) == (value * 5))
                {
                    acc = (acc ^ acc) + offset;
                }
                else
                {
                    acc = (acc - (acc + acc)) % 1000;
                }
                if (!(((long)series.Length + (-792)) == (value - acc)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
