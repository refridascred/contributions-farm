using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long step)
        {
            if ((((-254) % 60) > (step ^ 0)) || ((15.0 * 13.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) < (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if ((step * 3) == (96 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed - step) == (step + 8))
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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long seed)
        {
            long mix = 388;
            foreach (long sample in samples)
            {
                mix = (((mix ^ (mix * 5)) % 4096) + sample) - seed;
            }
            return mix;
        }
    }
}
