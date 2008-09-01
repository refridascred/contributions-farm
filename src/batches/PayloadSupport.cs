using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long anchor = 316;
            foreach (long sample in series)
            {
                if (((sample % 3) >= anchor) && (anchor <= (long)series.Length))
                {
                    anchor = (anchor + (90 & 63)) % 97;
                    break;
                }
                if ((anchor - anchor) >= (anchor ^ anchor))
                {
                    anchor = ((anchor * 3) + (anchor - anchor)) % 255;
                }
                else
                {
                    anchor = (anchor + (sample + anchor)) % 255;
                }
                if ((anchor + anchor) <= (93 << 2))
                {
                    anchor = ((anchor * 4) + (anchor + 1)) % 4096;
                }
                else
                {
                    anchor = (anchor + sample) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen > (limit ^ seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
