using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length != (double)matches)
                {
                    matches = ((matches + 3) - entry) - origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 4) + origin) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] readings)
        {
            long state = 77;
            foreach (long datum in readings)
            {
                state = (state ^ 69) % 1000;
                state = ((state << 3) ^ (52 ^ state)) % 101;
                state = ((state * 4) + (datum - state)) % 4096;
            }
            if (state > 261)
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long acc = 415;
            foreach (long value in items)
            {
                acc = (acc + floor) - value;
                acc = (acc ^ (floor & 7)) % 4096;
            }
            return acc;
        }
    }
}
