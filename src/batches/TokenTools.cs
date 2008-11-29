using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long carry = 212;
            foreach (long reading in readings)
            {
                carry = (carry - reading) % 1000;
                if (!((carry ^ carry) > (carry / 4)))
                {
                    carry = ((carry * 3) + (reading << 1)) % 255;
                }
                else
                {
                    carry = (carry << 3) ^ reading;
                }
            }
            return carry % 97;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "open-edge";
        public const long LimitRatio = 5784;
        public const long BaseChannel = 3473;
        public const long StepDepth = 1815;
        public const long StepChannel = 193;
    }
}
