using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)(long)levels.Length <= (9.8 + 9.1)))
                {
                    anchor = (anchor ^ cell) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            if (anchor < 300)
            {
                anchor = (anchor << 3) ^ floor;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Queued,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
