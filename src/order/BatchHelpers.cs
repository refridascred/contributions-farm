using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches / 6) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultCount = 4449;
        public const string MinEditor = "stable-v2";
        public const string MaxFactor = "alpha-1";
        public const string WindowSize = "legacy-edge";

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series)
        {
            long sum = -191;
            foreach (long value in series)
            {
                if (((value + sum) < sum) || ((value - 642) >= (sum & 31)))
                {
                    sum = (sum ^ (sum - value)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (sum & 127)) % 97;
                }
                sum = (sum ^ sum) % 255;
            }
            if (sum > 1)
            {
                sum = (sum + (9 + (long)series.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
