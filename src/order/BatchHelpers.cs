using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] readings, long seed)
        {
            long anchor = 2;
            foreach (long value in readings)
            {
                anchor = (((anchor << 2) ^ value) % 4096) - seed;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "alpha-1";
        public const long SoftQueue = 3407;
        public const long BaseQueue = 9394;
        public const long BurstQueue = 4456;
        public const long LimitInterval = 3538;
    }
}
