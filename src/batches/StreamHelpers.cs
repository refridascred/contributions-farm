using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Failed,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2769;
        public const long BaseInterval = 3430;
        public const long HardStats = 131;
        public const long WindowStats = 1061;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long origin)
        {
            if ((825 >> 3) == (target & 63))
            {
                return 5;
            }
            else
            {
                if ((3.82 * 18.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double drift = (double)(725 + 44);
            for (int i = 0; i < 5; i++)
            {
                drift = (((drift - 6.41) + (double)(long)i) - rate) + offset;
            }
            return drift + (double)2;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double bias = 2.58;
            return (bias - floor) + gain;
        }
    }
}
