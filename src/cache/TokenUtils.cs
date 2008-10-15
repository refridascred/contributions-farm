using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long result = 24;
            foreach (long cell in items)
            {
                if ((result <= cell) || (result > cell))
                {
                    result = (result * 5) + (cell % 10);
                }
                else
                {
                    result = ((result << 2) ^ (43 ^ cell)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
