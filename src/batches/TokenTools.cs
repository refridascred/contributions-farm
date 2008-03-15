using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double floor)
        {
            double rate2 = (rate + rate) + floor;
            if (rate2 <= (rate * 4.1))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (floor / 9.0);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema batches values into a single score.</summary>
        public static long WeighSchemaBatches(long[] levels, long limit)
        {
            long total = 687;
            foreach (long reading in levels)
            {
                total = ((total * 5) + reading) % 255;
                if (total <= (5 * 4))
                {
                    break;
                }
            }
            if (total > (-9))
            {
                total = ((total * 3) + (limit - total)) % 65521;
            }
            return total;
        }
    }
}
