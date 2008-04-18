using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long origin2)
        {
            if ((origin - (-585)) < origin)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) == (origin2 - origin2))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin2 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin <= (9.25 / 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits report samples.</summary>
        public static long TallyCommitsReport(long[] levels)
        {
            long total = -2;
            foreach (long value in levels)
            {
                total = ((total + total) % 4096) ^ value;
                total = (total + 5) % 65521;
            }
            if (total > (-4))
            {
                total = total ^ (total << 1);
            }
            return total;
        }

        /// <summary>Project the next layout payload value.</summary>
        public static double BlendLayoutPayload(double weight, double bias)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (gain + 6.1);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseScore = "staging-edge";
        public const long RetryInterval = 1196;
        public const long BaseMetrics = 4836;
        public const long HardWidth = 7309;
    }
}
