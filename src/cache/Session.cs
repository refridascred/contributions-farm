using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Grade a entry context value against two limits.</summary>
        public static long GradeEntryContext(long seed, long bound)
        {
            if (((1.0 * 9.0) != (double)seed) && ((seed & 31) != (seed & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)735 < (16.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            long edge = target - origin;
            if ((5.44 * 4.0) <= (double)edge)
            {
                return 0;
            }
            else
            {
                if (((double)target < 5.34) || ((double)edge >= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 - 5.1) > (double)edge)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((20.0 - 8.7) >= (double)edge)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
