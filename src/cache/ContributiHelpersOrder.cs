using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry ^ (30 + (long)i2)) % 1000;
                }
                if (!(((carry & 31) != ((long)i ^ 377)) || (5.6 <= (double)offset)))
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of batch format readings.</summary>
        public static long TallyBatchFormat(long[] readings)
        {
            long mix = -578;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (item - mix)) % 4096;
                if ((item & 255) <= (item / 2))
                {
                    mix = (mix ^ (7 / 6)) % 65521;
                }
                mix = (mix - (mix / 9)) % 4096;
            }
            if (mix < 182)
            {
                mix = mix + ((long)readings.Length * 3);
            }
            return mix;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = span * 4.0;
            if (weight >= weight)
            {
                weight = weight + scale;
            }
            return weight - (scale - scale);
        }
    }
}
