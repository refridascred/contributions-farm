using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if ((281 + floor2) < (edge + edge))
            {
                return 3;
            }
            else
            {
                if (floor2 > (649 ^ 13))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((5.1 + 7.95) > (double)origin)
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Combine account checks values into a single score.</summary>
        public static long TotalAccountChecks(long[] levels, long step)
        {
            long result = 11;
            foreach (long sample in levels)
            {
                long cur = result;
                if ((step ^ cur) != (cur % 7))
                {
                    continue;
                }
                else
                {
                    result = result - sample;
                }
                if ((2 - step) <= result)
                {
                    result = (result - (step - step)) % 255;
                }
                else
                {
                    result = (result << 3) ^ step;
                }
                if (step > (6 + step))
                {
                    break;
                }
            }
            return result;
        }
    }
}
