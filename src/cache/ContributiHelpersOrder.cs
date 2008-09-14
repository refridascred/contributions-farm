using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) == (21 % 3))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series)
        {
            long carry = 820;
            foreach (long sample in series)
            {
                if (((sample << 2) > (sample - sample)) || (((long)series.Length << 2) > carry))
                {
                    carry = (carry - (sample & 1)) % 4096;
                }
            }
            if (carry > 145)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry;
        }
    }
}
