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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (mix ^ (5 - mix)) % 1000;
                if (mix < (entry * 2))
                {
                    mix = mix + (entry << 2);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (origin ^ 8)) % 97;
            }
            return mix;
        }
    }
}
