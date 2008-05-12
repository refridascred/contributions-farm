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

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series, long bound)
        {
            long anchor = 446;
            foreach (long value in series)
            {
                anchor = ((anchor + (anchor >> 4)) - value) - bound;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Active,
            Failed,
            Done,
        }
    }
}
