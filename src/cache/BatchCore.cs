using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((4.13 + 16.0) < (double)state)
                {
                    state = (state << 2) ^ (604 + limit);
                }
                else
                {
                    state = (state << 2) ^ state;
                }
                state = (state - (4 + limit)) % 255;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double rate, double floor)
        {
            double mean = (double)(5 - 8);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + rate) + (double)(long)i) - floor;
            }
            return mean - (double)5;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
