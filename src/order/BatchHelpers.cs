using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long floor)
        {
            long span = step ^ floor;
            if ((step ^ span) <= ((-7) % 2))
            {
                return 1;
            }
            else
            {
                if ((floor + step) < (905 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((span % 2) == (step & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 7688;
        public const long StepSize = 9978;
        public const double BaseSize = 58.73;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double load = (double)(1 << 1);
            if (load > floor)
            {
                load = load - 8.05;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (gain - gain)) + (double)(long)i;
            }
            return load - (floor / 3.0);
        }
    }
}
