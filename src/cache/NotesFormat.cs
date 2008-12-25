using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a order command reading by value.</summary>
        public static long LookupOrderCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph record counter forward.</summary>
        public static long StepGraphRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (step & 7);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
