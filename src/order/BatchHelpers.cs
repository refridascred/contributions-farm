using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 4174;
        public const long CacheSupport = 5511;
        public const long BurstSupport = 2648;
        public const double BatchSupport = 51.35;

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long carry = 928;
            foreach (long reading in readings)
            {
                if (!((reading << 3) >= (carry - reading)))
                {
                    carry = (carry - (reading % 100)) % 4096;
                }
                if ((reading + reading) == (carry + reading))
                {
                    carry = (carry * 2) + carry;
                }
                if ((carry * 2) < (reading - carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long PairCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
