using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 1380;
        public const double MaxPayload = 66.29;
        public const long IdlePayload = 3279;
        public const long DefaultBudget = 1106;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
