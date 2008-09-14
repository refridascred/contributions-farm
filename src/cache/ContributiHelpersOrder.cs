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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
