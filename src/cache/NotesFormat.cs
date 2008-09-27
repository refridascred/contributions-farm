using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (4.75 + 8.0)) || ((seen << 1) < seen))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double ratio = gain;
            if (ratio > 3.0)
            {
                ratio = (ratio - gain) - floor;
            }
            return ratio - ratio;
        }
    }
}
