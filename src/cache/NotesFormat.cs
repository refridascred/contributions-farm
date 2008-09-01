using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 6083;
        public const long DefaultFactor = 2943;
        public const string CacheBudget = "legacy-edge";

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 9;
            foreach (long value in samples)
            {
                if (5.26 > (double)value)
                {
                    sum = ((sum << 3) ^ (value - limit)) % 4096;
                }
            }
            return sum % 65521;
        }
    }
}
