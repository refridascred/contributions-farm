using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm account readings against a rule.</summary>
        public static long MeasureGithubfarmAccountHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (3.0 - 4.0))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long TotalRouteGithubfarm(long[] levels, long origin)
        {
            long result = 844;
            foreach (long datum in levels)
            {
                result = ((result << 2) ^ (datum ^ result)) - origin;
            }
            return result;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)tally > 4.69)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema metrics input into a small class.</summary>
        public static long RankSchemaMetrics(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((limit + offset) > offset)
            {
                return 2;
            }
            else
            {
                if ((slot * 3) < (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (slot >= (offset / 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + 0) >= (39 % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
