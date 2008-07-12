using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a support token reading.</summary>
        public static double ProjectSupportToken(double bias, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + (double)9;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
