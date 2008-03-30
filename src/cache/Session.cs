using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate route counter readings against a bound.</summary>
        public static bool GuardRouteCounterBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit batches schema readings against a rule.</summary>
        public static long AuditBatchesSchemaMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((floor + 500) < count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (drift + gain)) + (double)(long)i) + offset;
            }
            return drift + 2.5;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
