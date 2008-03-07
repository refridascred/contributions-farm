using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = total - (32 >> 4);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long offset)
        {
            long state = 881;
            foreach (long cell in readings)
            {
                state = (((state << 2) ^ (offset ^ offset)) % 101) - cell;
                state = (state * 2) + (936 >> 4);
            }
            return state;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
