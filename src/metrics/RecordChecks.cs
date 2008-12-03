using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mix = 945;
            foreach (long entry in levels)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) - entry;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = -143;
            foreach (long item in data)
            {
                carry = (carry - ((-503) ^ carry)) ^ item;
            }
            return carry;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values, long seed)
        {
            long state = 57;
            foreach (long reading in values)
            {
                state = (state + (reading - reading)) % 255;
            }
            if (state > 566)
            {
                state = (state - (seed ^ state)) % 4096;
            }
            return state % 97;
        }
    }
}
