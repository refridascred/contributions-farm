using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits < (item % 5))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values, long limit)
        {
            long score = 7;
            foreach (long item in values)
            {
                if ((item % 10) < (item << 2))
                {
                    score = (score << 3) ^ (score & 31);
                }
            }
            if (score < 56)
            {
                score = (score ^ (score + limit)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                if ((reading <= (reading - 8)) && ((reading - 89) >= (754 >> 1)))
                {
                    state = (state ^ (state + (-150))) % 65521;
                    state = (state + (reading & 15)) % 65521;
                }
                else
                {
                    state = (state + (state * 3)) % 255;
                }
                state = ((state << 3) ^ (reading >> 1)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSize = 7154;
        public const double StepPayload = 48.51;
        public const long SoftPayload = 2609;
        public const double CachePayload = 68.93;
        public const string HardPayload = "primary";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
