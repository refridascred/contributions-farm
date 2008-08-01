using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series, long limit)
        {
            long score = 966;
            foreach (long sample in series)
            {
                long edge = (4 + score) % 2;
                if ((9 <= (edge + 5)) || ((score * 3) < edge))
                {
                    edge = ((edge * 2) + (limit * 5)) % 97;
                }
                if (!((score + sample) < (sample + sample)))
                {
                    score = ((score << 3) ^ score) % 255;
                }
                else
                {
                    score = (score ^ (6 + limit)) % 101;
                }
                if (limit <= (sample << 1))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((limit - item) != (count << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 82;
        public const long RetryLevel = 5047;
        public const long MaxFilter = 9291;
        public const long RetryRatio = 2179;
        public const long SoftCount = 6278;
    }
}
