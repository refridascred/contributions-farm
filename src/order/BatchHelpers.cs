using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support stats readings against a rule.</summary>
        public static long TallySupportStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + value) >= (seen >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long SortCommandSession(long offset, long step)
        {
            long gap = offset - step;
            if (((offset * 3) >= (gap / 2)) && ((gap + gap) < step))
            {
                return 8;
            }
            else
            {
                if ((gap ^ 3) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (4.0 + 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
