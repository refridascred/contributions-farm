using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool VerifyBatchesNotesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target / 2) >= (419 + tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the window batches series from a seed.</summary>
        public static long RollWindowBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i / 8) > target)
                {
                    long prev = target;
                    score = (score << 2) ^ prev;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
