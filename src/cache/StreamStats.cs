using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long AuditNotesCommandHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) == (476 % 12))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + 7) > (seen ^ cell))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double rate2 = (double)(59 - 635);
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate) - (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
