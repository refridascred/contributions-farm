using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] levels, long bound)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if (((4.55 / 5.0) != (double)score) && (sample < score))
                {
                    score = (score ^ 548) % 4096;
                    score = (score + (bound << 1)) % 4096;
                }
                score = (score - (bound ^ bound)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (356 - score)) % 255;
            }
            return score % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
