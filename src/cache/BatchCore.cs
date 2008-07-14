using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i < limit) || (34 >= (limit / 7)))
                {
                    anchor = (anchor * 5) + anchor;
                }
                anchor = (anchor + (limit - limit)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
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
