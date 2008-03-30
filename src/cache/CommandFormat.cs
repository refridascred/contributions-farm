using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count > (count + 12))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long RollCacheEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ (offset / 9)) % 255;
                if (((double)anchor > (5.13 + 4.45)) || (((long)i & 15) > (anchor / 4)))
                {
                    anchor = (anchor * 2) + offset;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Queued,
            Idle,
            Paused,
        }
    }
}
