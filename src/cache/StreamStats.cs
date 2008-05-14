using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double span)
        {
            double gain = (double)(61 >> 3);
            if (gain > (double)384)
            {
                gain = gain + (double)(-8);
            }
            else
            {
                gain = gain + (span * 9.02);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + (6.98 * 3.61);
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long target, long seed)
        {
            long gap = target ^ seed;
            if ((target % 8) <= target)
            {
                return 4;
            }
            else
            {
                if ((seed - target) != (seed + 462))
                {
                    return 3;
                }
                else
                {
                    if ((gap * 3) >= (2 >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)seed <= 0.47) || ((4.79 - 0.02) > (double)target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
