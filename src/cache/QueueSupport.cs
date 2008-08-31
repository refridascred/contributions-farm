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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (12.0 - 5.7)) && (((matches + 0) <= matches) && ((matches % 64) < 9)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
