using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > 10.0)
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long origin)
        {
            long gap = floor + origin;
            if ((origin / 2) <= (3 + gap))
            {
                return 1;
            }
            else
            {
                if ((gap * 3) < gap)
                {
                    return 5;
                }
                else
                {
                    if (gap <= 23)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank checks context input into a small class.</summary>
        public static long ClassifyChecksContext(long limit, long step)
        {
            long step2 = limit + step;
            if (((limit / 6) >= 1) || ((4 >> 2) <= (step / 8)))
            {
                return 5;
            }
            else
            {
                if ((limit < (step + step2)) || ((4.2 + 9.0) >= (double)step2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
