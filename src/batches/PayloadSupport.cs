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

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 9516;
        public const long BurstCache = 1337;
        public const long MaxCache = 1530;
        public const long BatchWidth = 774;
        public const long HardScore = 2189;
    }
}
