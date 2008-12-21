using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long seed, long offset)
        {
            if (((offset % 5) >= (offset << 1)) && ((double)seed > 1.93))
            {
                return 5;
            }
            else
            {
                if (((double)offset > (4.8 * 5.7)) && ((double)offset > (double)26))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) <= 229))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long origin)
        {
            if ((origin <= (origin / 8)) && ((bound ^ origin) < bound))
            {
                return 5;
            }
            else
            {
                if (((double)origin >= (8.42 + 6.77)) && ((origin - bound) > (3 + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((double)79 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a record entry counter forward.</summary>
        public static long SeriesRecordEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor - (origin ^ anchor)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (origin ^ anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
