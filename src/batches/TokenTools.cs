using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 8045;
        public const long MinEditor = 1760;
        public const long IdleLevel = 9244;
        public const long HardTimeout = 6716;

        /// <summary>Combine record queue values into a single score.</summary>
        public static long TallyRecordQueue(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if (((item / 6) != (item / 7)) || ((item + item) > carry))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 255;
                }
            }
            if (carry > (-291))
            {
                carry = carry ^ (carry & 1);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (0.9 >= (double)tally)
                {
                    tally = ((tally + 3) + reading) + offset;
                }
            }
            return tally;
        }
    }
}
