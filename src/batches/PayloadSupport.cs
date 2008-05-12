using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long MeasureNotesCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((1.0 > (double)seen) || ((28 + datum) >= datum)) && (datum < seen))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long offset)
        {
            long total = 18;
            foreach (long sample in levels)
            {
                total = (total + (7 + total)) + offset;
                if ((20.0 - 11.0) > (double)sample)
                {
                    total = ((total << 2) ^ total) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Locked,
            Ready,
            Retry,
            Stale,
        }
    }
}
