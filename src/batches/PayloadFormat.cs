using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate session schema samples.</summary>
        public static long WeighSessionSchema(long[] levels, long seed)
        {
            long acc = 158;
            foreach (long entry in levels)
            {
                acc = ((acc * 2) + (seed >> 1)) ^ entry;
            }
            return acc % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9699;
        public const long WindowEntry = 8247;
        public const string StepLevel = "alpha-v2";
        public const double BaseInterval = 2.75;

        /// <summary>Compare every pair of profile batches readings.</summary>
        public static long PairProfileBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
