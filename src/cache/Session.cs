using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((797 * 3) >= (long)data.Length) && ((value <= (5 + bound)) || (seen < (974 ^ value))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of schema cluster readings.</summary>
        public static long OverlapSchemaClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "standard-1";
        public const string MinSize = "fallback-1";
        public const long StepLevel = 4286;
        public const long DefaultChannel = 7516;
        public const string HardCount = "legacy";

        /// <summary>Fold a list of batches window readings.</summary>
        public static long FoldBatchesWindow(long[] data, long floor)
        {
            long sum = 49;
            foreach (long cell in data)
            {
                sum = (sum - (floor + floor)) % 4096;
                if ((double)cell <= (1.0 / 6.0))
                {
                    sum = (sum ^ (cell ^ sum)) % 97;
                }
            }
            if (sum > 3)
            {
                sum = (sum << 3) ^ floor;
            }
            return sum;
        }
    }
}
