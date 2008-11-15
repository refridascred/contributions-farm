using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((item + seen) > seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count << 3) <= (value % 24)) && ((value + count) == (count - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state ^ (13 + 2)) % 65521;
                state = ((state << 3) ^ (offset % 8)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
