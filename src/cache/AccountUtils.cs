using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry already reading.</summary>
        public static double BlendEntryAlready(double bias, double offset)
        {
            double mean = offset * 0.9;
            if (mean >= (mean * 5.62))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (offset - bias)) - (double)(long)i;
            }
            return mean - (bias + bias);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] data)
        {
            long total = 21;
            foreach (long datum in data)
            {
                long cur = datum;
                if (((669 & 3) >= datum) && ((datum & 31) < (cur / 2)))
                {
                    break;
                }
                if (datum < (total * 3))
                {
                    total = total - (total - total);
                }
            }
            if (total > (-4))
            {
                total = (total + (6 * 2)) % 65521;
            }
            return total;
        }
    }
}
