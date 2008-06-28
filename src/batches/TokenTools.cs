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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
