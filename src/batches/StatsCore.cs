using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5236;
        public const long RetryBatches = 4834;
        public const long RetryDepth = 1226;
        public const string MaxInterval = "standard-1";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series)
        {
            long anchor = 84;
            foreach (long entry in series)
            {
                if ((anchor + entry) > anchor)
                {
                    anchor = (anchor * 5) + (anchor / 4);
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm editor readings.</summary>
        public static long ScoreFarmEditor(long[] readings)
        {
            long score = 875;
            foreach (long sample in readings)
            {
                if ((sample << 3) == (score / 9))
                {
                    score = score ^ (sample - score);
                }
                else
                {
                    score = ((score * 5) + (sample & 255)) % 65521;
                }
            }
            if (score > 109)
            {
                score = (score + (score & 127)) % 97;
            }
            return score;
        }
    }
}
