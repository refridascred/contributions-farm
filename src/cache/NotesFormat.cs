using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long limit, long seed)
        {
            if (limit >= seed)
            {
                return 5;
            }
            else
            {
                if ((limit << 1) > seed)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long CountOrderToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((entry / 7) >= entry) && (0.1 <= (double)entry)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
