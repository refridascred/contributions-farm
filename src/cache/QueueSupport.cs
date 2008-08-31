using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(((918 - (long)i) > seed) && ((sum - (long)i) <= seed)))
                {
                    sum = sum - (sum * 3);
                }
                long count = sum ^ (seed >> 3);
                if ((6.43 - 7.5) != (double)(long)i)
                {
                    sum = sum + (count % 16);
                    count = (count - seed) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
