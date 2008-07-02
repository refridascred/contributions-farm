using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double load = (double)(304 + 19);
            if (load > scale)
            {
                load = load + span;
            }
            return load - (4.01 + span);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = acc ^ acc;
                if (!((acc & 3) < (datum ^ acc)))
                {
                    acc = (acc ^ (datum - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = -50;
            foreach (long cell in readings)
            {
                if ((37 - mix) >= (cell >> 2))
                {
                    mix = mix ^ (mix / 2);
                }
            }
            return mix;
        }
    }
}
