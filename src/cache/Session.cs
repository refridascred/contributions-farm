using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long result = 5;
            foreach (long datum in series)
            {
                if ((origin & 255) < origin)
                {
                    result = ((result << 2) ^ (origin + result)) + datum;
                }
                if ((double)0 >= (double)origin)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((0 < (step >> 3)) && ((value + step) >= step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache notes reading.</summary>
        public static double AdjustCacheNotes(double scale, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span / 9.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Compare every pair of channel context readings.</summary>
        public static long CompareChannelContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
