using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((332 + sample) != (hits & 15))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
