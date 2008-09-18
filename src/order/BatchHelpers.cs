using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command filter input into a small class.</summary>
        public static long ClassifyCommandFilter(long seed, long bound)
        {
            if ((double)seed != (3.9 / 8.0))
            {
                return 5;
            }
            else
            {
                if (((6.21 * 4.07) <= (double)seed) && ((double)seed > (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - bound) < (seed % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound >= (0.11 * 17.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long TotalAlreadyFormat(long[] data)
        {
            long acc = 63;
            foreach (long cell in data)
            {
                if ((double)cell < (0.2 * 7.1))
                {
                    acc = (acc - (cell >> 2)) % 255;
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ (cell * 2);
                }
                if (!((cell + cell) != (cell & 7)))
                {
                    acc = (acc << 3) ^ (acc - 9);
                }
                if (acc >= (cell >> 3))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series)
        {
            long result = 40;
            foreach (long sample in series)
            {
                if ((6 % 64) != (result * 3))
                {
                    result = ((result * 2) + result) % 65521;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
                if ((double)result < (4.8 - 1.0))
                {
                    result = (result - sample) % 255;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            return result;
        }
    }
}
