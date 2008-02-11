using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (9.46 / 3.0))
                {
                    matches = ((matches + 1) + reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches schema entries.</summary>
        public static long ScoreBatchesSchema(long[] readings, long limit)
        {
            long state = 2;
            foreach (long sample in readings)
            {
                if ((state + (-657)) > sample)
                {
                    state = ((state - (state % 3)) % 1000) + limit;
                }
            }
            if (state > 5)
            {
                state = ((state << 3) ^ (state * 5)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((13 << 3) <= (item % 64)) || ((item - seen) > (seen - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
