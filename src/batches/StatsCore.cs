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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) != (count & 255))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two entry route measurements.</summary>
        public static double AdjustEntryRoute(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)85) - (double)(long)i) - bias;
            }
            return drift + drift;
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
