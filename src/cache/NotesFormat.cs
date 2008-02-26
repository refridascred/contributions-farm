using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
