using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] readings, long offset)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                if (offset <= (offset - state))
                {
                    state = (state - ((long)readings.Length >> 2)) ^ entry;
                }
            }
            if (state > 44)
            {
                state = ((state << 2) ^ (long)readings.Length) % 97;
            }
            return state;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
