using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset + offset) > (carry - 5))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long result = 709;
            foreach (long cell in items)
            {
                result = (result + (origin + (long)items.Length)) - cell;
            }
            return result;
        }
    }
}
