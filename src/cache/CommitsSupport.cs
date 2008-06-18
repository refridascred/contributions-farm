using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool GuardToolsCommandLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double gain, double floor)
        {
            double weight = gain * 9.59;
            if (weight < gain)
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
