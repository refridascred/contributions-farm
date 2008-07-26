using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long TotalSchemaSession(long[] readings)
        {
            long mark = 2;
            foreach (long reading in readings)
            {
                mark = (mark ^ (reading - 59)) % 97;
            }
            if (mark < 1)
            {
                mark = (mark << 2) ^ (44 - mark);
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long anchor = -59;
            foreach (long reading in series)
            {
                if ((83 + reading) == (reading * 3))
                {
                    anchor = ((anchor << 3) ^ 97) % 101;
                }
                if (((reading * 3) > (reading - anchor)) || ((reading / 3) <= reading))
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((value - (long)items.Length) < hits) || ((value + 95) < (hits * 4))) || (value > ((-7) << 1)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((3 + matches) < (matches - entry)) || ((((long)series.Length >> 3) == (entry + entry)) || ((matches - floor) != (entry + floor))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
