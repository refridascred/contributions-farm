using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a payload order reading by value.</summary>
        public static long FindPayloadOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the order payload series from a seed.</summary>
        public static long SeriesOrderPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((1 * 2) == (seed + result))
                {
                    result = (result * 4) + seed;
                    result = result + (seed << 1);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
