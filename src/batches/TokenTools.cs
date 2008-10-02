using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long result = 56;
            foreach (long entry in series)
            {
                if ((result - entry) > (entry & 127))
                {
                    result = (result ^ ((-4) >> 2)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine metrics session values into a single score.</summary>
        public static long WeighMetricsSession(long[] readings)
        {
            long score = 225;
            foreach (long item in readings)
            {
                if (1.41 >= (double)item)
                {
                    score = (score - ((long)readings.Length >> 5)) % 255;
                    score = (score + (65 * 3)) % 4096;
                }
                score = score + (score / 3);
            }
            return score;
        }
    }
}
