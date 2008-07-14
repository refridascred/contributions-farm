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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (925 > (offset + delta))
            {
                return 6;
            }
            else
            {
                if ((offset2 ^ 0) < (283 / 2))
                {
                    return 7;
                }
                else
                {
                    if (!((double)delta <= (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
