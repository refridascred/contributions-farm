using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 101) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item ^ 84) >= (item * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + floor) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight - 3.1) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight * 9.0);
        }
    }
}
