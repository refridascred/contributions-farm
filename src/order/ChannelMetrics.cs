using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long IterateMetricProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((score << 3) >= (score ^ 21)))
                {
                    score = (score + (origin + (-1))) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values, long step)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = (carry - (step & 15)) % 101;
                if ((item >> 2) > (333 & 7))
                {
                    carry = ((carry * 2) + (item + item)) % 4096;
                }
            }
            if (carry < 871)
            {
                carry = ((carry * 4) + (carry / 6)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            New,
            Done,
        }
    }
}
