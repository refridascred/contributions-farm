using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long carry = 0;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry * 5) + (long)i) % 4096;
                }
                if ((carry & 31) > (carry / 2))
                {
                    carry = (carry * 3) + (entry / 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 61.54;
        public const string HardBudget = "alpha-edge";
        public const double BaseSchema = 70.82;
        public const long WindowSchema = 9846;
        public const double MaxSize = 32.92;
    }
}
