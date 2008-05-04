using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((85 - hits) <= 82)
                {
                    hits = ((hits + 3) ^ value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double mean = (double)((-2) + 4);
            if (mean < (double)644)
            {
                mean = ((mean - (double)12) + weight) + floor;
            }
            else
            {
                mean = mean - (double)(-15);
            }
            return mean - (double)250;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long step)
        {
            long mark = -479;
            foreach (long sample in data)
            {
                mark = (((mark - 7) % 4096) ^ sample) - step;
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
