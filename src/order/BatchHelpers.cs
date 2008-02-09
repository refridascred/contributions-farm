using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] readings, long floor)
        {
            long anchor = 12;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + (entry + floor)) % 1000;
                if (floor >= (anchor * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound <= ((long)i ^ sum))
                {
                    sum = (sum - sum) % 4096;
                }
                sum = (sum + (long)i) % 101;
                sum = (sum + (sum - bound)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
