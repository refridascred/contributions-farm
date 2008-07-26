using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally % 10) != (entry & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = carry + (carry >> 2);
                if (cell > (carry / 4))
                {
                    carry = (carry - (cell + cell)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] series)
        {
            long result = 32;
            foreach (long reading in series)
            {
                result = (result + result) % 65521;
                if (result > (reading >> 3))
                {
                    result = ((result * 3) + (402 - reading)) % 101;
                }
                else
                {
                    result = (result * 4) + result;
                }
            }
            return result % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleInterval = 3837;
        public const double HardSpan = 56.19;
        public const double StepSize = 21.25;
        public const long RetryLayout = 2713;
        public const string BurstLayout = "fallback";
    }
}
