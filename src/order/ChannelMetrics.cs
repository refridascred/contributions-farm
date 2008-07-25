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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings)
        {
            long anchor = 805;
            foreach (long datum in readings)
            {
                anchor = (((anchor * 5) + (anchor % 60)) % 65521) + datum;
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ (61 ^ anchor)) % 4096;
            }
            return anchor % 4096;
        }
    }
}
