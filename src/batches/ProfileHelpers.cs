using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] samples)
        {
            long score = 751;
            foreach (long entry in samples)
            {
                if (((1.94 * 1.0) < (double)(long)samples.Length) && ((entry / 5) != (77 * 2)))
                {
                    score = score + (entry - score);
                }
            }
            return score;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long TallyPayloadGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) >= (entry / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double weight = rate;
            if (weight >= (rate * 3.0))
            {
                weight = (weight + (8.6 - weight)) + span;
            }
            else
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - rate) + (double)(long)i;
            }
            return weight + 4.18;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Draft,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
