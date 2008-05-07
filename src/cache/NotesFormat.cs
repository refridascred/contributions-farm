using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of profile channel entries.</summary>
        public static long TotalProfileChannel(long[] items)
        {
            long mix = 656;
            foreach (long datum in items)
            {
                if (((datum - 10) >= 957) || ((datum & 3) <= (datum - datum)))
                {
                    mix = (mix ^ (10 + datum)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + matches) < (matches % 5))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
