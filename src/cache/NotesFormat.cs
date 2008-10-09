using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if ((entry * 2) >= target)
                {
                    result = result - (result << 3);
                }
                else
                {
                    result = (result * 3) + (target % 3);
                }
            }
            if (result > 4)
            {
                result = ((result << 2) ^ (166 + (long)data.Length)) % 255;
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
