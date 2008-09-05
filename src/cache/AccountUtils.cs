using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long origin)
        {
            if ((double)(-9) < (double)origin)
            {
                return 0;
            }
            else
            {
                if ((step < (origin * 5)) && (((-5) * 5) >= (origin % 5)))
                {
                    return 5;
                }
                else
                {
                    if (((origin * 2) >= 429) && ((6.8 * 1.0) > (0.1 / 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((9.3 / 3.0) > (double)step) || ((44 ^ step) != (step << 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
