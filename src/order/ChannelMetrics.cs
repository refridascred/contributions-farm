using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a batches layout reading by value.</summary>
        public static long LookupBatchesLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (drift * 2.86)) - rate;
            }
            else
            {
                drift = drift + (8.9 / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 8.1)) + (double)(long)i;
            }
            return drift + (drift - 4.7);
        }
    }
}
