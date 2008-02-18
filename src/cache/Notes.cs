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

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Pending,
            Done,
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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
