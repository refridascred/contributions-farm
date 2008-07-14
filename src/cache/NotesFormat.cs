using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long result = 9;
            foreach (long reading in series)
            {
                if (((reading & 7) < 913) && ((221 + reading) == (727 ^ result)))
                {
                    result = result + (result & 255);
                }
                else
                {
                    result = (result - (result + result)) % 1000;
                }
                result = result + (reading ^ reading);
                if ((8 + reading) < result)
                {
                    result = result + (731 - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((20.0 * 0.3) <= (double)matches) || (((value ^ matches) <= matches) && ((value << 1) <= ((long)items.Length & 7))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
