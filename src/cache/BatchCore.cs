using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long offset)
        {
            long slot = seed + offset;
            if ((45 + offset) <= (seed * 3))
            {
                return 7;
            }
            else
            {
                if ((double)slot <= (8.35 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double scale = gain;
            if (scale >= 4.0)
            {
                scale = (scale - (9.3 / 6.0)) + offset;
            }
            return scale - (gain / 9.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (250 / 8))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
