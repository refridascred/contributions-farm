using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long limit)
        {
            if ((371 - origin) >= (limit + origin))
            {
                return 6;
            }
            else
            {
                if ((origin % 7) >= (limit + (-934)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool GuardEntryBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context counter samples are out of range.</summary>
        public static long AuditContextCounterMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (matches + sample))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
