using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (limit + (long)i)) % 4096;
                carry = carry ^ (carry - limit);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items)
        {
            long state = 510;
            foreach (long item in items)
            {
                state = (state << 3) ^ (3 - item);
            }
            if (state < 294)
            {
                state = (state + (state << 1)) % 4096;
            }
            return state;
        }

        /// <summary>Match up support token samples.</summary>
        public static long OverlapSupportTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)hits >= (18.0 - 6.0))
                {
                    hits = ((hits + 2) ^ sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Idle,
            Dropped,
            Queued,
        }
    }
}
