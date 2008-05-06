using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((origin + 504) > offset)
            {
                return 4;
            }
            else
            {
                if ((double)step != (7.8 + 5.0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            if (((70 + origin) > (seed ^ 6)) && ((origin ^ seed) == (6 << 1)))
            {
                return 0;
            }
            else
            {
                if (!((seed << 2) >= (-7)))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (seed - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed > 7.6) || ((1 - origin) >= seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7992;
        public const double MaxPayload = 1.24;
        public const double BurstFactor = 49.9;
        public const string DefaultRatio = "legacy-edge";

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) <= (matches >> 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
