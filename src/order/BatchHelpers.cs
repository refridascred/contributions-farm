using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long floor)
        {
            long state = 783;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state - (state ^ (long)i)) % 65521;
                }
                if ((state < (floor % 60)) && ((reading - reading) >= 4))
                {
                    state = (state << 3) ^ ((long)readings.Length ^ state);
                }
                else
                {
                    state = (state + (reading + floor)) % 101;
                }
            }
            return state;
        }
    }
}
