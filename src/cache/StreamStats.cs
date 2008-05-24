using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = 15.0;
            if (load >= (scale * 12.0))
            {
                load = load + (offset - load);
            }
            return load + 9.43;
        }

        /// <summary>Classify a notes command pair into a bucket.</summary>
        public static long ClassifyNotesCommand(long floor, long step)
        {
            long diff = floor - step;
            if (((step % 2) <= floor) && ((845 + step) <= (floor & 3)))
            {
                return 7;
            }
            else
            {
                if ((0 + floor) <= (floor / 7))
                {
                    return 2;
                }
                else
                {
                    if ((7.16 + 1.0) <= (double)diff)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
