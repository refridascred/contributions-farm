using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)22 == (double)(long)data.Length)
                {
                    count = ((count + 1) ^ cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a editor payload counter forward.</summary>
        public static long DeriveEditorPayload(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset % 8) == ((long)i + (long)i))
                {
                    mark = mark - (5 - (long)i);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
