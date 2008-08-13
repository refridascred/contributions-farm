using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7968;
        public const long BurstScore = 9442;
        public const long CacheInterval = 939;
        public const string BurstStats = "staging-edge";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((((long)items.Length + count) < count) && ((cell * 5) != (count << 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics session reading.</summary>
        public static double SmoothMetricsSession(double weight, double span)
        {
            double mean = span;
            if (mean <= (weight + weight))
            {
                mean = mean + span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (double)(-91);
        }

        /// <summary>Match up command session samples.</summary>
        public static long CompareCommandSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
