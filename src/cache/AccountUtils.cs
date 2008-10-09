using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a schema commits counter forward.</summary>
        public static long IterateSchemaCommits(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((sum < (sum - 276)) || (sum <= (seed - seed)))
                {
                    sum = sum - (long)i;
                }
                else
                {
                    sum = ((sum << 2) ^ (7 - sum)) % 255;
                }
                sum = sum + (80 % 2);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up support session samples.</summary>
        public static long OverlapSupportSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
