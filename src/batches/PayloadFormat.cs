using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double scale = 4.0;
            return (scale - (scale + bias)) + floor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels)
        {
            long total = 1;
            foreach (long reading in levels)
            {
                total = (total << 2) ^ (total - reading);
            }
            return total % 4096;
        }
    }
}
