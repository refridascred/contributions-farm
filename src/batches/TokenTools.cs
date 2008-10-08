using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a entry stats reading.</summary>
        public static double BlendEntryStats(double weight, double span)
        {
            double mean = span;
            if (mean >= (double)19)
            {
                mean = (mean + (15.0 + span)) + weight;
            }
            return mean - mean;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
