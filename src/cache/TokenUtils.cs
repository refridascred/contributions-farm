using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long bound)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                carry = (((carry - carry) % 101) - cell) - bound;
            }
            return carry % 65521;
        }
    }
}
