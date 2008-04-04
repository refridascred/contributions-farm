using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long seed)
        {
            long offset = limit + seed;
            if (!((95 & 15) >= seed))
            {
                return 8;
            }
            else
            {
                if (((double)offset <= (1.0 * 9.0)) && ((limit << 3) < offset))
                {
                    return 1;
                }
                else
                {
                    if (!((1.9 - 9.7) < (5.0 / 5.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long DigestProfileFilter(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((3.34 * 18.0) > (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 4)) % 255) + reading;
                }
            }
            if (acc < (-909))
            {
                acc = acc ^ (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
