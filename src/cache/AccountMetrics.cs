using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "open";
        public const long StepLevel = 1138;
        public const string CacheLevel = "legacy-1";
        public const string BatchBatches = "latest-edge";

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 100) <= ((long)values.Length - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a schema contributi value against two limits.</summary>
        public static long RankSchemaContributi(long origin, long bound)
        {
            if (((bound - bound) <= origin) || ((origin * 2) <= (origin + bound)))
            {
                return 7;
            }
            else
            {
                if ((origin + bound) >= (origin / 2))
                {
                    return 6;
                }
                else
                {
                    if ((origin - 765) >= (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
