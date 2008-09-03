using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long floor, long bound)
        {
            if ((floor & 7) > (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((bound + 9) < (29 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((floor * 3) == (708 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor < (8.3 * 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long target, long seed)
        {
            long bound = target ^ seed;
            if (!((bound + bound) > (target - bound)))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long mix = 58;
            foreach (long sample in data)
            {
                if (0 <= (mix - sample))
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = (mix ^ (sample ^ 0)) % 65521;
                }
            }
            if (mix < 505)
            {
                mix = (mix ^ (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
