using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if ((edge << 1) > 2)
            {
                return 3;
            }
            else
            {
                if ((offset + 3) > edge)
                {
                    return 8;
                }
                else
                {
                    if ((51 + offset) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryBudget = 59.38;
        public const string MaxFilter = "standard-edge";
        public const string SoftFilter = "stable-edge";

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
