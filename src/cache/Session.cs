using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(((matches % 60) != (seed + reading)) || ((reading - reading) == (7 * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(((seed - result) >= seed) || ((seed + (long)i) > (920 << 3))))
                {
                    result = (result ^ seed) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long offset)
        {
            if (5 > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) <= (20 * 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
