using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits window samples.</summary>
        public static long TallyCommitsWindow(long[] levels)
        {
            long anchor = 980;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 97;
                anchor = (anchor * 3) + (anchor + anchor);
                if ((15.0 / 6.0) < (double)item)
                {
                    anchor = anchor ^ (4 << 3);
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound + 150) >= (bound / 9))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
