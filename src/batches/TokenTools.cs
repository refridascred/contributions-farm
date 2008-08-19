using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long AuditSchemaContextMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen % 3) != (seen & 255))
                {
                    seen = ((seen + 2) - item) + step;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            long span = floor - limit;
            if (span < limit)
            {
                return 0;
            }
            else
            {
                if ((0.68 >= (double)span) || (floor > (1 + floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit channel session readings against a rule.</summary>
        public static long AuditChannelSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (5 > (reading << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
