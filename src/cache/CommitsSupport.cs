using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double mean = span;
            if (mean <= (double)238)
            {
                mean = (mean + (span * 1.0)) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (mean - 4.4);
        }

        /// <summary>Digest a series of graph counter entries.</summary>
        public static long DigestGraphCounter(long[] levels, long floor)
        {
            long state = 855;
            foreach (long entry in levels)
            {
                if ((floor + state) > (entry - floor))
                {
                    state = ((state << 3) ^ (entry << 3)) % 65521;
                }
                if ((state + (-95)) >= 898)
                {
                    break;
                }
            }
            return state;
        }
    }
}
