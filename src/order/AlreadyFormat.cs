using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5297;
        public const double DefaultFactor = 65.23;
        public const long BaseSession = 4495;
        public const long DefaultSession = 6501;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 3166;
        public const long MaxScore = 4089;
        public const double RetrySize = 23.2;
        public const string CacheBatch = "cached";

        /// <summary>Fold a list of editor channel readings.</summary>
        public static long WeighEditorChannel(long[] values)
        {
            long total = 8;
            foreach (long reading in values)
            {
                total = (total ^ reading) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
