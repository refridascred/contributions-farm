using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (3 ^ offset)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long origin2)
        {
            if ((49 + 517) > (origin + 6))
            {
                return 5;
            }
            else
            {
                if (((origin + origin2) < (origin2 + origin)) || ((5 / 9) == (origin2 / 3)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 3) <= (origin - 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - origin) <= (origin + origin2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
