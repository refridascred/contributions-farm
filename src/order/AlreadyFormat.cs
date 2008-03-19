using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double scale, double floor)
        {
            double load = (scale - 4.6) / 3.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) - (double)(long)i) - floor;
            }
            return load + (scale / 6.0);
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (seed << 1)) ^ cell;
            }
            if (mix > 4)
            {
                mix = ((mix << 3) ^ seed) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data, long step)
        {
            long result = -4;
            foreach (long value in data)
            {
                result = (result + result) % 255;
                if (value <= (57 ^ result))
                {
                    result = (result - (step % 2)) % 65521;
                }
                else
                {
                    result = (result - (value + step)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
