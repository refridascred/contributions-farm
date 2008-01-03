using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 1806;
        public const double StepScore = 30.98;
        public const long WindowLevel = 6874;
    }
}
