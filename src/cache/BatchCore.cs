using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batches window readings against a rule.</summary>
        public static long AuditBatchesWindowGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((0 - seed) < (0 >> 5))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(seen >= cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7367;
        public const double BurstRoute = 5.48;
        public const long IdleInterval = 5839;
    }
}
