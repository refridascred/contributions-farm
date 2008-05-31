using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi tools readings.</summary>
        public static long TotalContributiTools(long[] series, long step)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc * 5) + (cell % 12)) % 65521;
                acc = acc + step;
            }
            if (acc > 19)
            {
                acc = ((acc << 3) ^ (step + acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double span)
        {
            double load = rate;
            if (load <= (double)89)
            {
                load = (load - load) - span;
            }
            return load + (17.0 - rate);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Locked,
            Stale,
            Active,
        }
    }
}
