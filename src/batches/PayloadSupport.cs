using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long seed)
        {
            if ((step - 608) != (906 + 669))
            {
                return 3;
            }
            else
            {
                if (((step >> 3) == (step << 3)) && ((double)seed <= (7.7 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((7 + step) < (step >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < (1.84 - 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 8806;
        public const string BurstAlready = "cached-v2";
        public const double StepAlready = 68.46;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long acc = 77;
            foreach (long entry in series)
            {
                acc = (acc ^ (entry ^ acc)) + offset;
            }
            return acc;
        }
    }
}
