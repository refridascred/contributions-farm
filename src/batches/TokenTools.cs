using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long step)
        {
            long gap = origin + step;
            if (((origin % 16) < origin) && ((gap << 2) > (779 >> 4)))
            {
                return 8;
            }
            else
            {
                if ((gap & 255) >= gap)
                {
                    return 7;
                }
                else
                {
                    if ((65 > (origin >> 3)) && (step >= (49 - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
