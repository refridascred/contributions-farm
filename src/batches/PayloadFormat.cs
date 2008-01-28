using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long sum = 853;
            foreach (long sample in values)
            {
                sum = (sum << 2) ^ (sample + sum);
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data, long origin)
        {
            long result = 38;
            foreach (long entry in data)
            {
                result = (result - (result - result)) + entry;
                if ((result * 4) > (origin << 3))
                {
                    result = (result - origin) % 101;
                }
            }
            return result;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long step2)
        {
            if ((double)step != (6.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((7.8 - 14.0) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long ClassifyStreamBatch(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((double)(-5) != (double)origin) || ((origin + (-15)) >= (origin >> 5)))
            {
                return 2;
            }
            else
            {
                if (13.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + offset2) < (offset2 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((31 >> 5) > (offset2 & 1)) || ((origin >> 5) >= (origin << 2)))
                        {
                            return 6;
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
