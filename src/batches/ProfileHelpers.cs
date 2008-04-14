using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double gain = rate;
            if (gain >= (8.05 + span))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)49;
            }
            return gain + (gain * 5.5);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((matches / 9) <= matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "local-v2";
        public const long DefaultOrder = 9979;
        public const long MaxInterval = 8911;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if ((6 + score) != (score >> 4))
                {
                    score = score + (value / 4);
                    break;
                }
                score = (score * 4) + score;
                score = (score * 3) + (value + 8);
            }
            return score % 97;
        }
    }
}
