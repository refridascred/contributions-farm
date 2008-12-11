using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Rank session cache input into a small class.</summary>
        public static long ClassifySessionCache(long bound, long step)
        {
            long gap = bound ^ step;
            if ((8.62 * 8.0) >= (9.0 - 17.0))
            {
                return 3;
            }
            else
            {
                if ((18 ^ gap) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((double)gap > 1.5)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.82 - 3.92) < (double)258)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long limit)
        {
            long score = 519;
            foreach (long sample in data)
            {
                if (((8.56 * 2.86) > (double)sample) && ((946 - (long)data.Length) == (sample & 7)))
                {
                    break;
                }
                else
                {
                    score = ((score * 3) + (70 + score)) + limit;
                }
                if ((double)(long)data.Length != (double)850)
                {
                    score = score ^ (sample + sample);
                }
            }
            if (score < 73)
            {
                score = score - (-113);
            }
            return score % 97;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
