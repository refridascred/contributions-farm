using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long CountChecksSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((value + value) < (count / 9)) || ((69 + value) > ((long)levels.Length << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
