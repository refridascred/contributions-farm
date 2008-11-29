using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long target)
        {
            if (!((target ^ target) <= (offset & 127)))
            {
                return 8;
            }
            else
            {
                if (((target * 5) > offset) || (80 > offset))
                {
                    return 2;
                }
                else
                {
                    if ((66 - offset) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset / 7) == (target / 6)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long target)
        {
            if (((target * 2) != (2 / 7)) && ((double)origin >= (8.51 / 6.0)))
            {
                return 5;
            }
            else
            {
                if ((double)target >= 3.07)
                {
                    return 7;
                }
                else
                {
                    if ((origin - origin) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((15.0 / 6.0) == (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
