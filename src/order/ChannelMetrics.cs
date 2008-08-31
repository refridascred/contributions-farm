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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
