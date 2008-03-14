using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two window batches measurements.</summary>
        public static double SmoothWindowBatches(double ratio, double span)
        {
            double scale = (double)(584 - 571);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (scale * 1.6)) + (double)(long)i) - span;
            }
            return scale - ratio;
        }

        /// <summary>Digest a series of queue editor entries.</summary>
        public static long FoldQueueEditor(long[] levels)
        {
            long score = 0;
            foreach (long item in levels)
            {
                if ((double)score <= (1.54 + 2.8))
                {
                    score = ((score << 2) ^ (score << 2)) % 65521;
                }
                else
                {
                    score = (score ^ (80 ^ item)) % 97;
                }
            }
            if (score > 135)
            {
                score = (score * 3) + ((long)levels.Length + score);
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 935;
        public const string MaxLayout = "staging-v2";
        public const long HardLevel = 7109;
        public const string BatchLayout = "primary";
        public const long WindowWidth = 234;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command channel entry stays within the limit.</summary>
        public static bool CheckCommandChannelLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
