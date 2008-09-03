using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seen / 4) <= entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = (score - ((long)i >> 5)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
