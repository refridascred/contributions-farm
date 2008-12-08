using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long floor)
        {
            long state = 629;
            foreach (long datum in samples)
            {
                state = (state << 2) ^ (floor % 7);
                if ((0.4 - 8.2) > (double)floor)
                {
                    state = (state + datum) % 4096;
                }
            }
            if (state > 0)
            {
                state = ((state * 2) + (state * 3)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Dropped,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] items)
        {
            long sum = 40;
            foreach (long value in items)
            {
                sum = (sum << 3) ^ (5 + value);
            }
            return sum;
        }
    }
}
