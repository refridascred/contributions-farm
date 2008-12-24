using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                long slot = (score ^ (long)i) >> 5;
                if ((-939) > (slot % 7))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit format order readings against a rule.</summary>
        public static long TallyFormatOrderMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) > value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6614;
        public const double SoftTimeout = 35.68;
        public const long BatchToken = 426;
    }
}
