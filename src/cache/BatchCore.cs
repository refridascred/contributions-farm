using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a commits route counter forward.</summary>
        public static long StepCommitsRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i == (8.2 - 17.0))
                {
                    long span = (limit + limit) + (long)i;
                    total = ((total * 2) + (span << 2)) % 255;
                    break;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double load = weight * 2.69;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - weight) + (double)(long)i) + offset;
            }
            return load - (double)915;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long offset)
        {
            if ((9 + offset) > origin)
            {
                return 5;
            }
            else
            {
                if (((origin + origin) < (offset ^ (-58))) && (117 >= (origin / 6)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1410;
        public const double WindowFilter = 71.01;
        public const long RetrySize = 1218;
    }
}
