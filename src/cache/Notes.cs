using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double gain = ratio + ratio;
            if (gain < (double)4)
            {
                gain = gain - (offset + ratio);
            }
            return gain - gain;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ acc;
                if (844 < (origin & 63))
                {
                    acc = (acc * 2) + (acc + acc);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long SortStreamEditor(long bound, long floor)
        {
            if ((floor - floor) > (36 - bound))
            {
                return 0;
            }
            else
            {
                if (((double)bound <= 5.3) || ((double)floor > (2.0 - 9.85)))
                {
                    return 8;
                }
                else
                {
                    if (bound > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double offset)
        {
            double drift = 3.92;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (6.7 - scale)) + (double)(long)i) - offset;
            }
            return drift + (double)8;
        }
    }
}
