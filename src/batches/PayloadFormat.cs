using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) > 86)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long TallyGraphToolsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((5.0 * 10.0) > (double)count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache already value from a seed.</summary>
        public static long SeriesCacheAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(offset >= (score ^ score)))
                {
                    score = (score * 4) + (score & 1);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum ^ 238) > datum)
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
