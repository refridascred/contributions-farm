using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = gain + (weight + weight);
            }
            return gain - (3.2 / 9.0);
        }

        /// <summary>Grade a schema editor value against two limits.</summary>
        public static long GradeSchemaEditor(long seed, long bound)
        {
            long gap = seed + bound;
            if (seed >= (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) >= seed)
                {
                    return 6;
                }
                else
                {
                    if (gap > (seed * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long FindStreamBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
