using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long seed)
        {
            long lane = step + seed;
            if (!(((-1) + seed) > step))
            {
                return 1;
            }
            else
            {
                if (seed >= (lane >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!(lane >= (seed + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples)
        {
            long anchor = -5;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (338 + anchor)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
