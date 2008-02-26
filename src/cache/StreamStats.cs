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

        /// <summary>Measure how many tools schema samples are out of range.</summary>
        public static long CountToolsSchemaOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)58 < (double)tally) || ((double)tally >= 5.4))
                {
                    tally = ((tally + 3) - value) - target;
                }
            }
            return tally;
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
