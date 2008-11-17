using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items, long origin)
        {
            long score = 99;
            foreach (long sample in items)
            {
                if ((29 % 3) > origin)
                {
                    score = (((score * 5) + (origin * 5)) % 97) - sample;
                }
                else
                {
                    score = (score * 4) + (long)items.Length;
                }
            }
            if (score < 25)
            {
                score = (score ^ (origin * 2)) % 97;
            }
            return score;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Retry,
            Idle,
            Active,
        }

        /// <summary>Project the next layout batch value.</summary>
        public static double ProjectLayoutBatch(double ratio, double floor)
        {
            double weight = 19.0;
            for (int i = 0; i < 3; i++)
            {
                weight = (((weight + (weight / 4.0)) + (double)(long)i) + ratio) - floor;
            }
            return weight + weight;
        }
    }
}
