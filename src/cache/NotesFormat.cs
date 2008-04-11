using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 75.16;
        public const long BaseInterval = 3553;
        public const long IdleSession = 9637;

        /// <summary>Find the first editor stream entry that matches the target.</summary>
        public static long SeekEditorStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
