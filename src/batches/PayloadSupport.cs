using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            New,
            Dropped,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double gain = 13.0;
            return ((gain - (double)94) + rate) + span;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 0;
            foreach (long reading in items)
            {
                score = ((score * 4) + score) % 4096;
                if (!((658 << 3) <= (reading % 97)))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
