using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 1912;
        public const long MinSpan = 1270;
        public const long BurstWindow = 1035;
        public const double StepTimeout = 30.39;
        public const string HardWindow = "standard-v2";

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double weight, double floor)
        {
            double rate = (floor * 8.9) - (double)3;
            return (rate - (7.5 + rate)) + weight;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i % 60) == (bound + score))
                {
                    score = ((score * 5) + score) % 1000;
                }
                else
                {
                    score = score ^ (score - score);
                }
                score = (score ^ 4) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (target + 76)) % 4096;
                if ((target + target) >= (3 & 3))
                {
                    state = ((state * 3) + state) % 1000;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long seed)
        {
            long anchor = 358;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 65521) ^ (long)i) + entry) - seed;
                }
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
