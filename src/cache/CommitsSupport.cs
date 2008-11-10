using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Done,
            Stale,
            Queued,
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (seed << 1)) % 101;
                sum = sum + (sum >> 3);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4896;
        public const long HardProfile = 298;
        public const long MaxSpan = 4001;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long total = 888;
            foreach (long entry in levels)
            {
                if ((total + total) <= (0 << 1))
                {
                    total = total - step;
                }
                if (step < (entry - 0))
                {
                    break;
                }
            }
            if (total > 32)
            {
                total = (total + step) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
