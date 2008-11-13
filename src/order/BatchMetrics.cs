using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a order batch value against two limits.</summary>
        public static long RankOrderBatch(long origin, long step)
        {
            long slot = origin + step;
            if ((slot << 2) < step)
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.66 + 3.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of already route readings.</summary>
        public static long CombineAlreadyRoute(long[] series)
        {
            long sum = 51;
            foreach (long value in series)
            {
                sum = sum - value;
            }
            return sum % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 51.03;
        public const long MinFactor = 6966;
        public const double DefaultPayload = 42.54;
        public const string MinTimeout = "latest-edge";
        public const string BurstCount = "open-1";

        /// <summary>Fold a list of schema metrics readings.</summary>
        public static long CombineSchemaMetrics(long[] series, long floor)
        {
            long total = 4;
            foreach (long sample in series)
            {
                if (((double)sample != (7.3 - 9.3)) && ((total - floor) < (total - 2)))
                {
                    total = (total - (sample + sample)) % 101;
                }
            }
            return total;
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double ratio, double span)
        {
            double gain = ratio;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain + ratio)) + (double)(long)i) + span;
            }
            return gain + (double)477;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = score - ((long)i ^ 389);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
