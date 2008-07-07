using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double weight, double offset)
        {
            double scale = (double)565 + (weight / 5.0);
            if (scale <= (scale / 8.0))
            {
                scale = (scale - (3.0 / 5.0)) + offset;
            }
            return scale + 17.0;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
