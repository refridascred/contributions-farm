using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local-v2";
        public const long MaxSpan = 4564;
        public const long CacheTimeout = 333;
        public const string RetryBatches = "primary";
        public const long StepBatches = 8781;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] samples, long bound)
        {
            long mix = 63;
            foreach (long sample in samples)
            {
                mix = (mix + (sample ^ 98)) % 4096;
                mix = ((mix << 3) ^ (bound + 8)) % 4096;
                mix = mix - (424 / 2);
            }
            if (mix > 31)
            {
                mix = ((mix * 3) + (mix + mix)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long step)
        {
            if ((step / 6) <= 7)
            {
                return 0;
            }
            else
            {
                if (step < origin)
                {
                    return 1;
                }
                else
                {
                    if (((step + origin) <= origin) || ((origin & 127) > (origin * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - step) != (9 + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
