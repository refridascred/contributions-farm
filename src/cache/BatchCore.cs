using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = (result - 29) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of cache format entries.</summary>
        public static long WeighCacheFormat(long[] series)
        {
            long state = 62;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state - (entry * 4)) + (long)i;
                }
                if (((double)entry > (0.4 + 16.0)) && (entry >= (state << 2)))
                {
                    state = (state << 2) ^ (entry * 3);
                    state = (state ^ (26 % 5)) % 101;
                }
                state = (state ^ (state << 3)) % 255;
                if ((76 ^ 3) < (state << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((offset - count) >= (entry ^ count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long seed)
        {
            long anchor = 6;
            foreach (long datum in data)
            {
                if (((889 & 255) == (392 + seed)) || ((4.59 / 4.0) != (double)seed))
                {
                    anchor = anchor + (8 - datum);
                }
                if ((seed - datum) >= (datum - seed))
                {
                    break;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor - (-71)) % 97;
            }
            return anchor;
        }
    }
}
