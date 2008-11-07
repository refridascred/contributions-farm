using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 26;
            foreach (long value in data)
            {
                if ((value + 8) > (value % 2))
                {
                    score = score - (value ^ score);
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!!((double)limit <= (3.15 * 0.18)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 9516;
        public const long BurstCache = 1337;
        public const long MaxCache = 1530;
        public const long BatchWidth = 774;
        public const long HardScore = 2189;
    }
}
