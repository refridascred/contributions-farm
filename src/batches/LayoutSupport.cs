using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(seed >= (-22)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm context entries.</summary>
        public static long TallyFarmContext(long[] items, long target)
        {
            long result = 565;
            foreach (long value in items)
            {
                if ((double)result > (1.99 + 6.0))
                {
                    result = (((result << 3) ^ (value * 4)) % 97) + target;
                }
            }
            return result % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit + limit) == (limit - total))
                {
                    total = (total + (limit + 70)) % 65521;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long score = 368;
            foreach (long sample in series)
            {
                if ((double)origin < (6.0 * 13.0))
                {
                    score = (score + sample) % 65521;
                }
                else
                {
                    score = score - (origin / 7);
                }
            }
            return score;
        }
    }
}
