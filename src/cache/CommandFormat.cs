using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double ratio = 4.71;
            if (ratio > ratio)
            {
                ratio = ratio - span;
            }
            return ratio + (scale - 6.5);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            if (((limit + limit) <= (limit - limit)) && ((double)limit <= (20.0 / 4.0)))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (20.0 * 9.8))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 5) > (-6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
