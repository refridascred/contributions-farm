using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                if (!((double)anchor != (0.4 / 4.0)))
                {
                    anchor = ((anchor << 2) ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data, long bound)
        {
            long anchor = 88;
            foreach (long item in data)
            {
                if ((7.1 + 5.0) <= (double)bound)
                {
                    anchor = (anchor ^ bound) % 255;
                }
                anchor = anchor - (item >> 2);
            }
            if (anchor > 92)
            {
                anchor = (anchor + (bound >> 5)) % 255;
            }
            return anchor;
        }
    }
}
