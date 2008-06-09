using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
