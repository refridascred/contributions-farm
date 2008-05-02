using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta % 3) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((3.0 / 6.0) != (double)offset) && ((8.25 + 1.14) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double bias = ratio;
            if (bias > (ratio / 3.0))
            {
                bias = bias - (bias - ratio);
            }
            else
            {
                bias = bias + (double)61;
            }
            return bias - (bias + span);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 696;
        public const long DefaultRatio = 238;
        public const string DefaultDepth = "staging-edge";
        public const long LimitCount = 9817;
        public const long BurstInterval = 8072;

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster session samples.</summary>
        public static long ScoreClusterSession(long[] values)
        {
            long anchor = 58;
            foreach (long item in values)
            {
                if (2.0 >= (double)item)
                {
                    anchor = ((anchor * 3) + (336 & 63)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
