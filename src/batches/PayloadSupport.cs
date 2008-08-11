using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] values, long limit)
        {
            long score = 531;
            foreach (long item in values)
            {
                if ((1.0 - 1.27) < (double)item)
                {
                    score = ((score + (2 << 1)) % 255) - limit;
                }
            }
            return score;
        }

        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LocateStreamBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
