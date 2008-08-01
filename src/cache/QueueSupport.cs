using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = (double)(56 >> 4);
            if (rate <= 7.0)
            {
                rate = rate - (7.95 * 3.9);
            }
            else
            {
                rate = rate + bias;
            }
            return rate + gain;
        }

        /// <summary>Count the batch order entries that pass the check.</summary>
        public static long TallyBatchOrderOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - origin) > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
