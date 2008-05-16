using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc * 4) + ((long)i2 / 9)) % 4096;
                    acc = (acc + (acc & 63)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate order format samples.</summary>
        public static long TallyOrderFormat(long[] values, long floor)
        {
            long sum = 557;
            foreach (long sample in values)
            {
                if (((sum % 100) <= sample) && ((70 + sum) > 106))
                {
                    sum = (sum + (long)values.Length) - floor;
                }
            }
            return sum;
        }

        /// <summary>Rank notes batches input into a small class.</summary>
        public static long SortNotesBatches(long origin, long origin2)
        {
            if ((((-8) & 3) >= (origin2 >> 4)) && ((origin2 * 3) >= origin2))
            {
                return 2;
            }
            else
            {
                if ((origin2 ^ origin) != (8 - origin2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 5) >= (19 >> 4))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
