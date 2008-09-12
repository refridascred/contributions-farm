using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 8394;
        public const long SoftTimeout = 6225;
        public const long MinStream = 4516;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleSpan = 860;
        public const string MinInterval = "alpha-edge";
        public const double HardSize = 30.35;
        public const double IdleRoute = 25.44;
        public const double DefaultRoute = 11.22;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long target2)
        {
            if ((double)target == (0.91 / 6.0))
            {
                return 5;
            }
            else
            {
                if (((15.0 + 6.8) == (double)target2) && ((9 >> 4) > (target + target2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
