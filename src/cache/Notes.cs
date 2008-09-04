using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = 9.7;
            if (ratio <= gain)
            {
                ratio = (ratio - (ratio / 5.0)) - floor;
            }
            return ratio + (double)13;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long floor)
        {
            long carry = 42;
            foreach (long reading in readings)
            {
                carry = (carry - 26) % 1000;
                if ((reading - floor) >= (carry / 9))
                {
                    carry = ((carry << 2) ^ reading) % 97;
                }
                else
                {
                    carry = (carry << 2) ^ reading;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if (!!((anchor - step) <= anchor))
                {
                    anchor = ((anchor * 2) + (anchor >> 5)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long RollAlreadyChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor - seed);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "standard-1";
        public const string MinCounter = "strict-1";
        public const long CacheScore = 5715;
    }
}
