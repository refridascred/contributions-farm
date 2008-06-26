using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] items, long offset)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (((result * 4) + result) + entry) + offset;
            }
            if (result < 9)
            {
                result = result + 3;
            }
            return result % 1000;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio + floor)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
