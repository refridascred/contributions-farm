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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 15; i++)
            {
                total = total ^ (total * 4);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
