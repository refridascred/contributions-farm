using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long floor)
        {
            long delta = origin - floor;
            if ((double)delta >= (double)636)
            {
                return 3;
            }
            else
            {
                if ((573 + floor) > 302)
                {
                    return 1;
                }
                else
                {
                    if ((floor >= (origin - delta)) && ((double)origin == (1.8 - 4.68)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)value != (double)origin) || ((double)origin >= (3.8 / 8.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long sum = -506;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ (-70)) % 65521) ^ reading;
            }
            if (sum > 305)
            {
                sum = (sum - (bound >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long sum = 83;
            foreach (long value in levels)
            {
                if ((20.0 / 8.0) == (double)value)
                {
                    sum = (sum << 2) ^ (258 >> 1);
                    sum = (sum + (value << 3)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum << 3) ^ (value ^ value)) % 1000) - (long)i;
                }
                if ((sum % 16) != (value + 926))
                {
                    sum = (sum << 3) ^ (sum & 3);
                }
            }
            if (sum > 299)
            {
                sum = (sum * 3) + (88 ^ sum);
            }
            return sum % 97;
        }
    }
}
