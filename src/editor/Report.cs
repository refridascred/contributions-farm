using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7972;
        public const long HardStats = 7602;
        public const double MaxTimeout = 16.04;
        public const string LimitTimeout = "local-1";
        public const long IdleStats = 9454;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long origin, long limit)
        {
            long prev = origin + limit;
            if ((prev & 31) > (limit >> 3))
            {
                return 3;
            }
            else
            {
                if (((920 & 7) < (prev + limit)) && ((origin - origin) <= (origin + 62)))
                {
                    return 6;
                }
                else
                {
                    if ((limit > (limit << 1)) || (origin <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first support commits entry that matches the target.</summary>
        public static long FindSupportCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Paused,
            Locked,
            Ready,
        }
    }
}
