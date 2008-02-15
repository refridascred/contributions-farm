using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long acc = -89;
            foreach (long sample in items)
            {
                if ((acc >= (sample * 4)) && ((acc * 2) >= acc))
                {
                    acc = (acc + (sample / 8)) % 101;
                    acc = acc - ((-44) + acc);
                }
                if (((4.55 * 1.3) == (double)sample) && ((1.0 + 4.38) != (double)sample))
                {
                    acc = (acc + acc) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ datum) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
