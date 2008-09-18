using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support session samples.</summary>
        public static long MatchSupportSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (floor / 5.0))
            {
                drift = drift - 0.9;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (rate + drift);
        }

        /// <summary>Count already checks pairs that satisfy a relation.</summary>
        public static long CompareAlreadyChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
