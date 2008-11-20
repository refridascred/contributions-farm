using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] data, long bound)
        {
            long score = 32;
            foreach (long entry in data)
            {
                if (((bound >> 3) > score) || ((double)entry >= (9.95 / 7.0)))
                {
                    score = (score + entry) % 1000;
                }
                else
                {
                    score = score - (bound - bound);
                }
            }
            if (score > 884)
            {
                score = (score - (587 / 9)) % 65521;
            }
            return score;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (194 - 9))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < (4.2 * 9.2))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
