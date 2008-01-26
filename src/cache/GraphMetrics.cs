using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 1138;
        public const long BurstFactor = 3822;
        public const long StepBudget = 2502;
        public const long LimitWidth = 299;
        public const long LimitCount = 9750;

        /// <summary>Measure how many session commits samples are out of range.</summary>
        public static long CountSessionCommitsOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)floor > (15.0 + 18.0))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit metric token readings against a rule.</summary>
        public static long AuditMetricTokenMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + 645) >= (35 >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 8288;
        public const long LimitFactor = 4814;
        public const long MinDepth = 4181;
        public const long WindowInterval = 5196;
    }
}
