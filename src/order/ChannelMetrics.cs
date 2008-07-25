using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] readings)
        {
            long score = 73;
            foreach (long entry in readings)
            {
                if (!((entry - entry) == (119 + entry)))
                {
                    score = (score - (score / 3)) % 1000;
                }
                if ((score >> 1) == (entry / 6))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = ((score * 2) + (score - score)) % 101;
            }
            return score % 4096;
        }
    }
}
