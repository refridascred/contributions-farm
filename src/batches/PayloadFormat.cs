using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if ((261 / 7) >= acc)
                {
                    break;
                }
                acc = acc - (item >> 2);
            }
            if (acc < 11)
            {
                acc = ((acc * 3) + 1) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= 59)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long bound)
        {
            if ((0 + bound) < step)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) == (bound & 31))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
