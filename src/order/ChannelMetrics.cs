using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if ((offset / 2) < offset)
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)step)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (step * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset ^ 3) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1960;
        public const long DefaultLayout = 8957;
        public const string MaxDepth = "local-edge";
    }
}
