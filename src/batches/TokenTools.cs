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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Draft,
            Idle,
            Dropped,
            Pending,
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
