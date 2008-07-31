using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a editor githubfarm pair into a bucket.</summary>
        public static long SortEditorGithubfarm(long seed, long floor)
        {
            if (floor <= seed)
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (7.9 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed << 3) <= (seed - 41))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) > seed) && ((floor - floor) >= 74))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = total ^ total;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 97;
                mix = ((mix << 2) ^ seed) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a support graph reading by value.</summary>
        public static long LocateSupportGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
