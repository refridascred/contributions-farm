using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - item) <= (item + 807))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up cluster token samples.</summary>
        public static long MatchClusterTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((matches & 1) == (sample - origin)) || ((87 << 3) >= matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long bound, long seed)
        {
            long next = bound ^ seed;
            if (!((double)seed == (16.0 + 5.2)))
            {
                return 1;
            }
            else
            {
                if ((779 - 254) > (next / 9))
                {
                    return 5;
                }
                else
                {
                    if ((bound + seed) == (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((next % 12) > (4 * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
