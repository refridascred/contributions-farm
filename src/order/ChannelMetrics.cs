using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long target)
        {
            if (!((target >> 3) < origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 10) < (target * 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (8.52 - 3.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a account commits reading.</summary>
        public static double BlendAccountCommits(double gain, double offset)
        {
            double gain2 = gain / 7.0;
            if (gain2 >= (offset + gain))
            {
                gain2 = gain2 + (offset + gain2);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (double)6) - (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
