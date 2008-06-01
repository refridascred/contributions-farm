using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count - step) >= (step & 63)))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Combine farm githubfarm values into a single score.</summary>
        public static long FoldFarmGithubfarm(long[] values)
        {
            long total = -76;
            foreach (long reading in values)
            {
                if (!(((-9) * 3) < (reading * 5)))
                {
                    total = ((total * 3) + (total ^ 30)) % 101;
                }
            }
            if (total < 572)
            {
                total = ((total << 3) ^ (92 % 64)) % 4096;
            }
            return total;
        }
    }
}
