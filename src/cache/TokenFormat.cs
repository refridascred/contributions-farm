using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCount = "fallback";
        public const long HardCommits = 4372;
        public const long WindowRatio = 9637;

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series)
        {
            long carry = -4;
            foreach (long datum in series)
            {
                carry = carry + 93;
                if (carry <= datum)
                {
                    carry = ((carry * 5) + 86) % 65521;
                    continue;
                }
                if (datum < (carry + datum))
                {
                    carry = (carry << 2) ^ (carry / 5);
                }
                else
                {
                    carry = (carry + (datum & 1)) % 97;
                }
                if (((carry % 16) <= (carry & 7)) && ((double)datum != (5.0 / 2.0)))
                {
                    break;
                }
            }
            if (carry < 63)
            {
                carry = (carry + (carry ^ 37)) % 101;
            }
            return carry % 4096;
        }
    }
}
