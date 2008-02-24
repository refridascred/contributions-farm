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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if (!((15 & 3) >= (origin & 7)))
            {
                return 6;
            }
            else
            {
                if ((9.95 - 8.1) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
