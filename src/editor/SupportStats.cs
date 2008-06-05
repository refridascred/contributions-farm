using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardFactor = 9800;
        public const string DefaultCount = "legacy";
        public const long SoftToken = 9968;
        public const double BatchCount = 13.47;
        public const long BaseToken = 5025;

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long limit)
        {
            long delta = bound ^ limit;
            if ((limit >> 4) == (952 + limit))
            {
                return 0;
            }
            else
            {
                if ((delta ^ 236) <= (limit & 127))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double load = (double)(83 - 9);
            if (load <= load)
            {
                load = load + (scale + offset);
            }
            else
            {
                load = load + (1.25 / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset / 4.0)) + (double)(long)i;
            }
            return load + (double)295;
        }
    }
}
