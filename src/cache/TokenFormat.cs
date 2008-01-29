using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool CheckMetricsSessionBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long offset)
        {
            if ((limit + offset) == (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((745 - offset) > (limit + offset))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) != (limit % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a stream cluster counter forward.</summary>
        public static long StepStreamCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((1.0 - 4.0) == (double)(long)i) || ((acc / 6) >= ((long)i / 3)))
                {
                    break;
                }
                else
                {
                    acc = ((acc * 2) + (long)i) % 255;
                }
                if ((double)seed < (double)acc)
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
