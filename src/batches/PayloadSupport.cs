using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result + (reading & 127)) % 255;
                if ((reading <= 540) || (52 > (limit - limit)))
                {
                    result = result ^ (reading + result);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result + result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 1568;
        public const double DefaultScore = 13.65;
        public const string MinInterval = "alpha-edge";
        public const double BaseRatio = 93.12;
        public const double HardSession = 52.21;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
