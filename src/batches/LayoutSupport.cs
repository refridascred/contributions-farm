using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - (-609)) != (893 ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long TotalGithubfarmToken(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = acc ^ 2;
                if ((13.0 * 17.0) > (double)acc)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 66)
            {
                acc = acc ^ (4 + acc);
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series)
        {
            long mix = 64;
            foreach (long entry in series)
            {
                if ((68 + entry) != (253 + entry))
                {
                    mix = (mix ^ (916 << 2)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
