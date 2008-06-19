using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long mix = 36;
            foreach (long reading in readings)
            {
                mix = (mix + (reading & 63)) % 65521;
                if ((reading - mix) < reading)
                {
                    mix = ((mix * 2) + reading) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - reading)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double BlendCacheCommand(double rate, double offset)
        {
            double mean = (double)6 / 4.0;
            if (mean < (15.0 / 6.0))
            {
                mean = (mean - offset) - rate;
            }
            return mean + (mean + offset);
        }
    }
}
