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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches + (-228)) != (3 % 64)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
