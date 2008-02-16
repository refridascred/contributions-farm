using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
