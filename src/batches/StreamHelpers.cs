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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 904;
            foreach (long value in values)
            {
                if (!((double)value > (double)state))
                {
                    state = (state ^ (value & 63)) % 1000;
                }
                if ((value + 911) <= value)
                {
                    state = ((state << 2) ^ (state - state)) % 1000;
                }
            }
            return state;
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
