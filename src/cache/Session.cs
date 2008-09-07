using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long total = 1;
            foreach (long cell in data)
            {
                total = (total ^ (cell ^ bound)) % 1000;
            }
            if (total < 61)
            {
                total = total + total;
            }
            return total % 4096;
        }

        /// <summary>Combine command cache values into a single score.</summary>
        public static long TotalCommandCache(long[] items, long step)
        {
            long result = 64;
            foreach (long entry in items)
            {
                if ((double)entry <= (9.8 / 6.0))
                {
                    result = (result - (entry + entry)) % 1000;
                }
            }
            if (result > 517)
            {
                result = (result ^ (step >> 5)) % 255;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long bound)
        {
            long cur = offset + bound;
            if ((6 + offset) != (cur - bound))
            {
                return 6;
            }
            else
            {
                if (!((4.75 / 9.0) > (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}
