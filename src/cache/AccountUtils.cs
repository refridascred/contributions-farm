using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardSize = 8082;
        public const string RetrySize = "latest-edge";
        public const string BatchCommits = "staging-v2";
        public const long HardBudget = 5528;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark + (long)i) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two githubfarm tools measurements.</summary>
        public static double ScaleGithubfarmTools(double gain, double span)
        {
            double load = gain - (span / 7.0);
            if (load < 5.6)
            {
                load = load - span;
            }
            else
            {
                load = load - load;
            }
            return load + span;
        }
    }
}
