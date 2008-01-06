using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long seed, long origin)
        {
            if ((seed + origin) <= (seed + seed))
            {
                return 0;
            }
            else
            {
                if (((seed & 3) != (6 * 2)) && (seed <= origin))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 7) <= (origin ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed >> 2) != (origin % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a entry report figure with a bias.</summary>
        public static double SmoothEntryReport(double weight, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (offset + 7.0)) + (double)(long)i;
            }
            return mean + (offset - weight);
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double offset)
        {
            double mean = (double)(9 / 7);
            if (mean > (offset - ratio))
            {
                mean = mean - (0.36 * 7.26);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio - 4.0)) + (double)(long)i;
            }
            return mean - (mean - offset);
        }
    }
}
