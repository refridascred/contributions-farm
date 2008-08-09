using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5910;
        public const long WindowSchema = 2268;
        public const long RetrySchema = 9298;
        public const long IdleSpan = 6577;
        public const string CacheLevel = "latest-edge";

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if (((reading << 2) < (score - score)) || ((double)517 > (double)score))
                {
                    score = (score << 2) ^ (score * 2);
                }
                else
                {
                    score = (score ^ (score - reading)) % 255;
                }
                if ((score + 1) <= reading)
                {
                    score = ((score << 3) ^ 4) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
