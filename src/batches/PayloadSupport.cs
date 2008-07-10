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

        /// <summary>Match up commits graph samples.</summary>
        public static long CompareCommitsGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
