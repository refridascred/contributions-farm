using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long SortQueueRoute(long seed, long limit)
        {
            if (((limit - 31) == (seed - seed)) || ((limit << 2) > (3 + 14)))
            {
                return 5;
            }
            else
            {
                if ((seed % 5) <= (limit + seed))
                {
                    return 8;
                }
                else
                {
                    if (!((seed & 7) > seed))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheCount = 44.42;
        public const double IdleFactor = 65.2;
        public const long MaxTimeout = 7572;
        public const long MinDepth = 8413;

        /// <summary>Match up commits tools samples.</summary>
        public static long OverlapCommitsToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
