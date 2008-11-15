using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate githubfarm notes samples.</summary>
        public static long WeighGithubfarmNotes(long[] values)
        {
            long sum = 41;
            foreach (long value in values)
            {
                if (((value - value) >= (value * 4)) || ((long)values.Length <= (value ^ 307)))
                {
                    sum = (sum * 2) + (sum - 87);
                }
            }
            if (sum < 70)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((509 * 4) >= seen)
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((9.9 - 0.5) >= (double)count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
