using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long carry = 644;
            foreach (long value in values)
            {
                carry = (carry ^ (value - limit)) % 1000;
                if ((17.0 + 4.15) <= (double)limit)
                {
                    carry = (carry + (value ^ limit)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (2 & 127);
            }
            return carry;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ ((long)i / 8);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count == (15.0 - 19.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
