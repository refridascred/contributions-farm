using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count buffer stats pairs that satisfy a relation.</summary>
        public static long CompareBufferStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long total = 29;
            foreach (long sample in data)
            {
                if (!((2 / 9) != ((long)data.Length - total)))
                {
                    total = (total ^ (sample % 8)) % 4096;
                }
                else
                {
                    total = (total + total) % 101;
                }
            }
            if (total > 84)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long offset, long bound)
        {
            if (5.2 < (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(((-69) + bound) <= bound))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.6) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next context metrics value from a seed.</summary>
        public static long IterateContextMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark * 4) + (-20);
                if (floor >= 94)
                {
                    mark = ((mark * 4) + 85) % 255;
                    mark = ((mark << 2) ^ (floor >> 4)) % 1000;
                }
                mark = (mark << 2) ^ (floor - floor);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit graph order readings against a rule.</summary>
        public static long AuditGraphOrderGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((2.8 / 2.0) != (double)seen) || ((76 * 4) == (seen & 31)))
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
