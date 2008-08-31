using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (!(total <= ((long)i >> 2)))
                {
                    continue;
                }
                total = (total - target) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                long span = (result ^ result) & 255;
                if (((long)i + span) >= (997 * 2))
                {
                    result = result ^ (406 >> 1);
                    continue;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= 1.0)
            {
                gain2 = gain2 - (gain * 1.45);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (gain2 / 9.0)) + (double)(long)i;
            }
            return gain2 - (gain * 8.24);
        }
    }
}
