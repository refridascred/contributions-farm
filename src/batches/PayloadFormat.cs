using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long seed)
        {
            long lane = step ^ seed;
            if ((double)lane < (5.0 / 6.0))
            {
                return 5;
            }
            else
            {
                if (!((double)lane >= (8.9 - 13.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = (state + (item - state)) % 101;
                if ((21 <= (item * 3)) || (207 < (item + state)))
                {
                    state = state - (item + item);
                }
                if ((291 ^ state) <= (1 / 6))
                {
                    break;
                }
            }
            if (state < 63)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
