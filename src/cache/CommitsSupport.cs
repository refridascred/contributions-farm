using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long CountFarmLayoutOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + count) != (count & 15)) || !((644 - (-52)) < (reading + reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 768;
        public const long DefaultTimeout = 9322;
        public const long WindowLayout = 5155;
        public const long StepLayout = 8079;
    }
}
