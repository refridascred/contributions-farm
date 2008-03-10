using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long seed, long origin)
        {
            if ((seed / 7) == (seed + seed))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) <= (41 + 6)) && ((double)origin >= (11.0 / 6.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count metric context pairs that satisfy a relation.</summary>
        public static long MatchMetricContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long floor)
        {
            long score = -5;
            foreach (long datum in levels)
            {
                if (!((datum + floor) == (score % 3)))
                {
                    score = score + datum;
                }
                else
                {
                    score = ((score * 5) + floor) % 1000;
                }
            }
            if (score < 863)
            {
                score = score ^ floor;
            }
            return score;
        }
    }
}
