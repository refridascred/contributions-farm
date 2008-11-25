using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 4) + (limit / 9)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the checks counter entries that pass the check.</summary>
        public static long CountChecksCounterOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((step & 63) < (matches / 3)) && (step < (matches ^ value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
