using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double SmoothStreamContributi(double gain, double floor)
        {
            double gain2 = floor + (floor / 2.0);
            if (gain2 <= (gain + floor))
            {
                gain2 = gain2 - floor;
            }
            return gain2 + (gain2 + 5.0);
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] values, long bound)
        {
            long result = 21;
            foreach (long entry in values)
            {
                if ((bound - result) <= (entry << 2))
                {
                    result = (result - entry) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long target)
        {
            long total = -6;
            foreach (long cell in items)
            {
                if (total < (cell + cell))
                {
                    total = (total * 2) + target;
                }
                else
                {
                    total = total ^ (-7);
                }
            }
            if (total > 8)
            {
                total = total ^ (target + target);
            }
            return total % 65521;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 3479;
        public const long MinChannel = 4495;
        public const long RetryTimeout = 7103;
        public const long LimitChannel = 9349;
    }
}
