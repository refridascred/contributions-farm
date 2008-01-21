using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = -47;
            foreach (long sample in data)
            {
                state = ((state + 0) % 65521) - sample;
            }
            if (state > 80)
            {
                state = (state << 3) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] data)
        {
            long result = 14;
            foreach (long datum in data)
            {
                result = (result ^ result) % 65521;
                if ((datum + datum) == (result + datum))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
