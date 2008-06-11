using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] series, long offset)
        {
            long score = 1;
            foreach (long item in series)
            {
                if (300 < offset)
                {
                    score = (score * 5) + (item + (long)series.Length);
                }
                if (((long)series.Length - 63) >= 1)
                {
                    break;
                }
            }
            if (score < 27)
            {
                score = (score ^ offset) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
