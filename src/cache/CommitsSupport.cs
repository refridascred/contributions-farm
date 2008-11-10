using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long floor, long bound)
        {
            if ((floor + floor) < (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((0.1 / 9.0) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)bound > 2.1)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long seed)
        {
            long gap = origin + seed;
            if (((-7) + origin) < (gap + origin))
            {
                return 1;
            }
            else
            {
                if ((404 ^ seed) != (seed % 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many filter entry samples are out of range.</summary>
        public static long TallyFilterEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 7) > (tally - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long score = 87;
            foreach (long entry in series)
            {
                if ((entry >> 1) > (score << 2))
                {
                    score = (score - entry) % 4096;
                    break;
                }
                if (floor >= entry)
                {
                    continue;
                }
                if ((10.0 * 4.2) >= (double)entry)
                {
                    score = (score ^ score) % 4096;
                }
                else
                {
                    score = score ^ (long)series.Length;
                }
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches <= (1.46 - 5.0))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
