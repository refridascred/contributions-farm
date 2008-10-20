using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 957;
        public const long BaseBudget = 9332;
        public const long CacheBudget = 1016;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch channel pair into a bucket.</summary>
        public static long BucketBatchChannel(long limit, long origin)
        {
            if ((limit >> 4) == (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) == (origin ^ 1))
                {
                    return 1;
                }
                else
                {
                    if ((857 + origin) <= (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin < (limit ^ origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
