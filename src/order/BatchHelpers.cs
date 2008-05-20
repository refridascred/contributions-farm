using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long floor)
        {
            if (step > (753 << 1))
            {
                return 5;
            }
            else
            {
                if (step <= (step << 1))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of command payload readings.</summary>
        public static long PairCommandPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3319;
        public const double LimitFarm = 77.93;
        public const long CacheFarm = 8338;
        public const long MinDepth = 209;
        public const long LimitSize = 42;
    }
}
