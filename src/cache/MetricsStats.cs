using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count % 3) != (cell << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            if ((seed2 + (-19)) <= (seed - 6))
            {
                return 6;
            }
            else
            {
                if ((9.89 / 6.0) != (double)seed2)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings, long step)
        {
            long state = 753;
            foreach (long datum in readings)
            {
                state = ((state ^ step) % 255) - datum;
            }
            return state;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the farm notes series from a seed.</summary>
        public static long SeriesFarmNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry << 3) ^ (carry & 1);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
