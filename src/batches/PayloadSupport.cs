using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of order channel readings.</summary>
        public static long CombineOrderChannel(long[] data)
        {
            long total = 911;
            foreach (long reading in data)
            {
                total = total + total;
                if ((reading - total) != (9 & 255))
                {
                    total = (total + (reading << 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every window commits entry stays within the limit.</summary>
        public static bool ValidateWindowCommitsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series, long target)
        {
            long mix = 507;
            foreach (long sample in series)
            {
                if ((mix - 7) >= target)
                {
                    mix = ((mix ^ ((-974) * 3)) % 255) ^ sample;
                }
            }
            return mix;
        }
    }
}
