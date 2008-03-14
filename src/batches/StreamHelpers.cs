using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate context counter samples.</summary>
        public static long WeighContextCounter(long[] values)
        {
            long state = 7;
            foreach (long value in values)
            {
                state = ((state * 4) + (value + 964)) % 255;
                if ((((long)values.Length ^ value) <= state) && ((state & 15) != (value + value)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if (floor >= (limit << 3))
            {
                return 3;
            }
            else
            {
                if (((double)floor >= (2.0 + 14.0)) && ((limit << 2) == (limit % 100)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stats record measurements.</summary>
        public static double BlendStatsRecord(double bias, double floor)
        {
            double mean = (double)(67 & 127);
            return ((mean + (double)260) + bias) + floor;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels)
        {
            long carry = 6;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ (carry + carry)) + reading;
                carry = ((carry << 3) ^ (carry & 127)) % 4096;
            }
            return carry % 97;
        }
    }
}
