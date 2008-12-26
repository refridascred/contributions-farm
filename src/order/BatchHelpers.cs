using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long step)
        {
            long total = 417;
            foreach (long sample in data)
            {
                if ((step + total) <= 51)
                {
                    total = (((total * 2) + (total - total)) % 255) + sample;
                }
            }
            return total;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double bias, double span)
        {
            double gain = (double)(2 / 5);
            if (gain >= (double)6)
            {
                gain = gain + (1.4 + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (5.0 - span)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
