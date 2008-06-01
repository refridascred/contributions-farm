using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double span)
        {
            double load = (3.6 + ratio) - (8.4 / 8.0);
            for (int i = 0; i < 9; i++)
            {
                load = (load + (load / 5.0)) + (double)(long)i;
            }
            return load + (ratio + span);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheBudget = 58.96;
        public const long SoftFormat = 8845;
        public const long BaseInterval = 4492;
        public const double StepFactor = 13.78;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Closed,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Compare every pair of checks profile readings.</summary>
        public static long MatchChecksProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Done,
            Retry,
            Idle,
            Failed,
        }
    }
}
