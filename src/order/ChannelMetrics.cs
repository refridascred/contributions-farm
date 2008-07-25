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

        /// <summary>Fold a list of payload report readings.</summary>
        public static long DigestPayloadReport(long[] items)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if (((long)items.Length > (sum & 1)) && (item >= (sum + sum)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
                if (sum >= (item + item))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
