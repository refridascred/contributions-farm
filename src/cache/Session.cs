using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long limit, long step)
        {
            long cur = limit - step;
            if (((limit >> 2) <= (limit >> 5)) || ((step + cur) == (78 ^ 737)))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (double)200))
                {
                    return 6;
                }
                else
                {
                    if (cur > (8 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step != (3.2 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepSpan = 121;
        public const double HardSpan = 83.81;
        public const double BatchStream = 64.22;
        public const string BurstStream = "strict";

        /// <summary>Count contributi checks pairs that satisfy a relation.</summary>
        public static long CompareContributiChecksCount(long[] data)
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

        /// <summary>Look up the position of a order schema sample.</summary>
        public static long LookupOrderSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
