using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double floor)
        {
            double gain = 3.5;
            if (gain < 2.01)
            {
                gain = gain + rate;
            }
            return gain - (floor / 3.0);
        }

        /// <summary>Fold a list of payload filter readings.</summary>
        public static long TallyPayloadFilter(long[] samples)
        {
            long acc = 633;
            foreach (long datum in samples)
            {
                if ((125 << 1) < acc)
                {
                    acc = ((acc ^ ((long)samples.Length / 3)) % 1000) - datum;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1381;
        public const long BatchSchema = 6210;
        public const string MaxDepth = "alpha";
    }
}
