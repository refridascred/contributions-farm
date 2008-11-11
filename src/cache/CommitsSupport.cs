using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Closed,
            New,
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
