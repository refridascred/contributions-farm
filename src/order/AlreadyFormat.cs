using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 8.55;
        public const double SoftGraph = 58.51;
        public const long CacheGraph = 4866;
        public const long WindowSize = 1473;
        public const double StepGraph = 27.78;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                if (bound <= acc)
                {
                    acc = (acc + (acc % 12)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((11.0 / 5.0) <= (10.0 + 4.63))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
