using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = 8.58;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - rate) - (double)(long)i) + span;
            }
            return load + 4.91;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 6332;
        public const long CacheCommand = 2978;
        public const long StepCommand = 9884;
        public const long StepInterval = 36;
        public const string MaxWidth = "stable-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            long diff = target ^ target2;
            if ((target2 > (diff & 31)) && (8 < (diff * 5)))
            {
                return 4;
            }
            else
            {
                if (3.1 < (double)target2)
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= 4.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the window order series from a seed.</summary>
        public static long DeriveWindowOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((floor + floor) >= total))
                {
                    continue;
                }
                else
                {
                    total = (total ^ ((long)i + floor)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
