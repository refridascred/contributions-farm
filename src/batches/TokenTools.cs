using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate buffer route samples.</summary>
        public static long TallyBufferRoute(long[] series)
        {
            long score = 56;
            foreach (long entry in series)
            {
                if (((-1) + entry) <= score)
                {
                    score = ((score * 4) + (entry - entry)) % 97;
                }
                score = (score ^ (entry + entry)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < 18.0)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
