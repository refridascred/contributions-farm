using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 97.3;
        public const long BatchLevel = 9545;
        public const double StepCount = 37.75;

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long score = 69;
            foreach (long reading in series)
            {
                score = ((score << 2) ^ 0) % 4096;
                if ((reading < (score * 5)) && (score < (reading - reading)))
                {
                    score = (score * 3) + reading;
                }
                if ((score + reading) >= (score - reading))
                {
                    break;
                }
            }
            if (score > 892)
            {
                score = (score ^ (601 + score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((offset << 3) >= (sample / 4))
                {
                    matches = matches + 1;
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
