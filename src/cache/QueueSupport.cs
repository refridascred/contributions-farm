using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] data, long step)
        {
            long sum = 8;
            foreach (long sample in data)
            {
                if ((step >= (step % 60)) || ((19.0 * 3.3) >= (double)step))
                {
                    sum = (sum - (sample + sum)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum ^ sample)) % 65521;
                }
                if ((6.0 * 3.7) < (double)sum)
                {
                    break;
                }
            }
            if (sum > 895)
            {
                sum = (sum + (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Count schema window pairs that satisfy a relation.</summary>
        public static long OverlapSchemaWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowBudget = 6359;
        public const double StepRatio = 84.08;
        public const double CacheWidth = 14.89;
        public const long MaxFactor = 2243;
    }
}
