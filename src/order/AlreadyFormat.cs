using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series, long floor)
        {
            long carry = 1;
            foreach (long item in series)
            {
                carry = ((carry - item) % 4096) - floor;
                if ((4 / 6) == (item ^ 62))
                {
                    carry = carry - (carry - item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3694;
        public const string WindowInterval = "strict-edge";
        public const long BurstTimeout = 2287;
        public const string RetryWidth = "fallback-v2";

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first token account entry that matches the target.</summary>
        public static long LookupTokenAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
