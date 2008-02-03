using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a stream profile reading.</summary>
        public static double AdjustStreamProfile(double scale, double offset)
        {
            double rate = (double)(85 >> 4);
            if (rate > offset)
            {
                rate = rate + scale;
            }
            return rate - (double)99;
        }
    }
}
