using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double load = scale * 2.7;
            if (load > bias)
            {
                load = load - load;
            }
            else
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Grade a batch session value against two limits.</summary>
        public static long RankBatchSession(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound & 15) < (step << 3))
            {
                return 3;
            }
            else
            {
                if (!((step + step) <= step))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "stable-edge";
        public const long BurstInterval = 7305;
        public const long WindowToken = 8896;

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long StepEntryTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ limit) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
