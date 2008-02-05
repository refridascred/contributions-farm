using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first cluster entry entry that matches the target.</summary>
        public static long LocateClusterEntryIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin & 3) >= 8)
                {
                    score = (score - (7 - (long)i)) % 97;
                    break;
                }
                else
                {
                    score = ((score * 2) + (origin & 7)) % 65521;
                }
                if ((881 * 2) != (963 - score))
                {
                    score = ((score << 3) ^ (98 + (long)i)) % 4096;
                    score = (score * 4) + ((-12) - origin);
                }
                score = (score + origin) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long anchor = 2;
            foreach (long cell in data)
            {
                if (94 >= (anchor ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (cell % 10)) % 255;
                    break;
                }
                if (anchor > (cell % 10))
                {
                    anchor = anchor - (cell + anchor);
                }
                if ((6 >> 3) >= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long origin)
        {
            long edge = seed ^ origin;
            if ((edge + edge) <= (seed + seed))
            {
                return 3;
            }
            else
            {
                if (((2 + edge) != (edge - origin)) || ((origin % 5) > (seed << 1)))
                {
                    return 8;
                }
                else
                {
                    if (1.8 <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((double)(-68) > (double)origin) || (origin < (seen + origin)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long seed)
        {
            long mark = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 3) + (long)i) % 97) - seed;
                }
                if ((mark * 3) < item)
                {
                    mark = ((mark * 4) + (item * 5)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
