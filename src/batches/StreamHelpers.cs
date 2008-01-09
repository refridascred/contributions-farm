using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)item >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long bound)
        {
            if ((double)seed != (double)(-1))
            {
                return 7;
            }
            else
            {
                if (bound < (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (((bound >> 4) == (seed ^ bound)) || ((8.0 - 14.0) >= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel commits readings.</summary>
        public static long CompareChannelCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            long bound = step - step2;
            if (((bound + bound) > step2) || ((step / 7) >= bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step2 * 4) < (step2 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((9.9 * 8.6) >= (double)step2) || ((bound << 1) >= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((double)limit <= (6.81 / 4.0)) && (limit <= (hits >> 5))))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 4266;
        public const string StepLevel = "latest-v2";
        public const string BaseTools = "alpha-1";
        public const long BatchTools = 9215;
        public const long MaxSpan = 9743;
    }
}
