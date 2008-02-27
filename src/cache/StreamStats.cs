using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long bound)
        {
            long diff = floor + bound;
            if ((6 ^ bound) != (bound & 1))
            {
                return 3;
            }
            else
            {
                if ((7.0 * 16.0) < (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((floor * 5) < diff)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + sum) % 1000;
                if (!(offset <= (sum + offset)))
                {
                    sum = sum ^ ((long)i - sum);
                    sum = (sum << 3) ^ (sum - (long)i);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a layout queue value against two limits.</summary>
        public static long BucketLayoutQueue(long step, long floor)
        {
            if ((step + step) >= (floor & 31))
            {
                return 6;
            }
            else
            {
                if ((step & 7) > step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
