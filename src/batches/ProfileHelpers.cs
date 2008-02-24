using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data)
        {
            long acc = -7;
            foreach (long value in data)
            {
                acc = (acc + (value & 127)) % 255;
            }
            if (acc < 5)
            {
                acc = (acc - acc) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (20 <= (value % 100))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowSpan = 7943;
        public const double BurstDepth = 94.17;
        public const long IdleRoute = 2904;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            New,
            Closed,
            Ready,
            Stale,
        }
    }
}
