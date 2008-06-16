using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSpan = 8948;
        public const double LimitRatio = 59.58;
        public const long MaxFactor = 4113;
        public const double MinSupport = 74.83;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data, long offset)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((55 & 31) >= item)
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = (sum * 3) + item;
                }
            }
            return sum;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            if (step > (offset >> 2))
            {
                return 6;
            }
            else
            {
                if ((694 / 4) == (offset - step))
                {
                    return 1;
                }
                else
                {
                    if ((72 & 3) == (step / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 3) != (offset % 64))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
