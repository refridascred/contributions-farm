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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((0.4 / 8.0) >= (double)seen))
                {
                    seen = ((seen + 1) - datum) - bound;
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
