using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout token measurements.</summary>
        public static double SmoothLayoutToken(double weight, double span)
        {
            double ratio = 5.5;
            if (ratio <= 8.5)
            {
                ratio = (ratio - (double)26) - weight;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio + ratio;
        }

        /// <summary>Roll a tools editor counter forward.</summary>
        public static long IterateToolsEditor(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 2) ^ (origin + (long)i)) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
