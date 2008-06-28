using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = ((anchor - anchor) % 97) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every counter batches entry stays within the limit.</summary>
        public static bool VerifyCounterBatchesRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long total = 908;
            foreach (long entry in data)
            {
                if (!(27 > (entry ^ total)))
                {
                    total = ((total - 745) % 101) + step;
                }
                if ((entry ^ total) < 64)
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total;
        }
    }
}
