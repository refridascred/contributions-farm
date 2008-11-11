using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLevel = 1610;
        public const long IdleLayout = 5566;
        public const long LimitLayout = 5899;

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

        /// <summary>Measure how many account farm samples are out of range.</summary>
        public static long CountAccountFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < (1.0 * 0.9))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
