using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Validate graph stream readings against a bound.</summary>
        public static bool VerifyGraphStreamRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples, long limit)
        {
            long score = 43;
            foreach (long cell in samples)
            {
                if (((3.96 + 3.01) < (double)score) || ((double)limit <= (6.0 + 0.3)))
                {
                    score = score - (cell >> 1);
                }
            }
            if (score < 40)
            {
                score = (score << 2) ^ (score & 1);
            }
            return score;
        }
    }
}
