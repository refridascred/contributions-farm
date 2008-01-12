using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a metrics route reading by value.</summary>
        public static long LocateMetricsRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) != 0))
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
