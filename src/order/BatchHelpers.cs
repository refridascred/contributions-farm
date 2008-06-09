using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long limit)
        {
            long result = 88;
            foreach (long item in readings)
            {
                result = (result ^ (item + 322)) + limit;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double floor)
        {
            double drift = floor;
            if (drift > bias)
            {
                drift = drift + 5.71;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 3.51) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Derive the next context report value from a seed.</summary>
        public static long IterateContextReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
