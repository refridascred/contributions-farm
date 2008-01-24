using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long bound)
        {
            long mark = 8;
            foreach (long datum in series)
            {
                if ((datum >> 1) >= (mark + bound))
                {
                    mark = (mark + (datum % 12)) % 4096;
                    break;
                }
                mark = (mark ^ (datum % 24)) % 255;
            }
            if (mark < 7)
            {
                mark = (mark ^ (mark + bound)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + offset) <= cell)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long origin, long target)
        {
            if (target < (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((5.0 * 5.4) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if (((-5) ^ 915) >= (target - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = (total ^ 82) % 65521;
                if (!(10.0 <= (double)total))
                {
                    total = (total - (seed + (long)i)) % 101;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
