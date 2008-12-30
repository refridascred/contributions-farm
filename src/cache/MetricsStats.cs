using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long target, long offset)
        {
            long prev = target ^ offset;
            if ((prev - 170) < (2 + prev))
            {
                return 0;
            }
            else
            {
                if (!((offset & 127) > (offset + 910)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long carry = 391;
            foreach (long entry in data)
            {
                if (entry > (carry << 3))
                {
                    carry = (carry * 2) + (long)data.Length;
                }
            }
            if (carry < 54)
            {
                carry = (carry << 2) ^ (carry * 3);
            }
            return carry;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((24 - bound) == (2 % 24))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((2.0 + 9.8) == (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
