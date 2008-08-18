using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9732;
        public const long RetryGithubfarm = 7793;
        public const string BaseSpan = "staging-v2";

        /// <summary>Blend two already batches measurements.</summary>
        public static double ProjectAlreadyBatches(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < (ratio + 0.1))
            {
                gain = gain - (double)9;
            }
            return gain + offset;
        }
    }
}
