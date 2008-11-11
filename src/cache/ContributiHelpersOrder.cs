using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long state = 924;
            foreach (long reading in levels)
            {
                if ((origin - reading) > reading)
                {
                    state = ((state << 2) ^ (reading + reading)) % 4096;
                }
            }
            if (state > 52)
            {
                state = state + (state * 2);
            }
            return state % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "cached-1";
        public const long BurstWindow = 5221;
        public const long CacheWindow = 4831;
        public const string StepRatio = "fallback-v2";
        public const long StepWindow = 3230;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if (((bound % 10) != (step & 31)) && ((bound / 6) > (step << 3)))
            {
                return 1;
            }
            else
            {
                if ((5.0 - 19.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 3) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 2) >= ((-82) + bound))
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
        }
    }
}
