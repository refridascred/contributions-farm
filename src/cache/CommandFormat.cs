using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long target)
        {
            if ((origin + origin) == (4 * 4))
            {
                return 8;
            }
            else
            {
                if (((origin & 3) > (target << 1)) && ((68 ^ target) >= (target / 2)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            long lane = bound - offset;
            if (lane < (bound + offset))
            {
                return 0;
            }
            else
            {
                if (!((lane + 0) >= (lane * 2)))
                {
                    return 7;
                }
                else
                {
                    if (!((offset + bound) != (57 + lane)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound == (2.0 / 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
