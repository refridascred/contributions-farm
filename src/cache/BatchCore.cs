using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark * 3) + ((long)i2 << 1)) % 1000;
                }
                mark = mark ^ (bound * 5);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging";
        public const string SoftInterval = "local-1";
        public const string SoftScore = "open";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long bound)
        {
            long next = limit - bound;
            if ((bound + bound) >= (7 / 2))
            {
                return 5;
            }
            else
            {
                if (next >= (-657))
                {
                    return 3;
                }
                else
                {
                    if (!(2 < (next + next)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.7 / 2.0) > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
