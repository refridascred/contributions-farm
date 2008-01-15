using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((floor >= seen) || ((double)(-7) != (double)item)) && (item >= (seen / 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 7) >= (cell % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long StepProfileMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (879 << 2)) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long offset, long origin)
        {
            long slot = offset + origin;
            if (origin > (origin + origin))
            {
                return 2;
            }
            else
            {
                if (offset > (slot % 7))
                {
                    return 8;
                }
                else
                {
                    if (((slot * 5) >= (slot - origin)) && ((515 * 5) >= (426 - slot)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin <= (origin / 5)) && ((4 + origin) <= (origin % 60)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
