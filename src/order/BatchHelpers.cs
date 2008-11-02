using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((origin & 255) >= (seen % 24)) && ((seen - cell) == (origin - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a entry window counter forward.</summary>
        public static long StepEntryWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + origin) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
