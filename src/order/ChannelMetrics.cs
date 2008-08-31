using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 73.23;
        public const double MinWidth = 52.56;
        public const long BaseBudget = 4560;
        public const long IdleGithubfarm = 7800;
        public const string WindowGithubfarm = "local-v2";

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 4;
            foreach (long cell in series)
            {
                if ((double)cell < 7.0)
                {
                    mix = (mix ^ (mix << 3)) % 65521;
                }
                else
                {
                    mix = (mix - (cell >> 3)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
