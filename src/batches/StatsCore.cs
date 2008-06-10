using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ seen) >= (seen + datum))
                {
                    seen = (seen + 2) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (target >= (target / 6))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Derive the next already profile value from a seed.</summary>
        public static long IterateAlreadyProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (!(floor <= slot))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) >= (slot + seed))
                {
                    return 0;
                }
                else
                {
                    if (seed < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor << 1) <= seed) || (17.0 > (double)slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
