using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((45 << 3) != (reading + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 4) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] data, long origin)
        {
            long anchor = 395;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) >= (double)origin)
                {
                    anchor = (anchor + (datum << 1)) % 4096;
                }
            }
            if (anchor > (-67))
            {
                anchor = (anchor * 2) + (883 + 322);
            }
            return anchor % 97;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
