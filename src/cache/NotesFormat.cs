using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of command token entries.</summary>
        public static long TallyCommandToken(long[] items)
        {
            long sum = 25;
            foreach (long cell in items)
            {
                if (!!((cell + cell) > (sum - cell)))
                {
                    sum = ((sum << 2) ^ (sum << 2)) % 4096;
                }
                sum = (sum + (cell * 4)) % 65521;
            }
            return sum;
        }
    }
}
