using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                if ((mark >> 2) > (cell >> 4))
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Pending,
            Stale,
            New,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count * 3) > (count ^ value))
                {
                    count = (count + 3) + origin;
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
