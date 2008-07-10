using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxRatio = 9590;
        public const string CacheLayout = "strict-v2";
        public const long BurstLayout = 1054;
        public const long MaxLayout = 9695;
        public const long RetryLayout = 193;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long origin, long step)
        {
            long span = origin + step;
            if ((span << 3) <= step)
            {
                return 1;
            }
            else
            {
                if (((-7) > span) || ((origin & 7) != (span - span)))
                {
                    return 8;
                }
                else
                {
                    if ((span % 3) > (91 + step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >> 3) >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
