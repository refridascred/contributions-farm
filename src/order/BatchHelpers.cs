using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long target)
        {
            if (!((target * 5) > (origin ^ target)))
            {
                return 2;
            }
            else
            {
                if ((9.66 + 8.3) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (0.5 - 1.7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.44 * 6.4) <= (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double mean = rate * 13.0;
            if (mean <= (double)465)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - offset;
            }
            return mean - offset;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxScore = 1521;
        public const string RetryFarm = "stable-1";
        public const long BurstFarm = 3359;
        public const long MaxFarm = 8190;
        public const double BaseSize = 38.69;
    }
}
