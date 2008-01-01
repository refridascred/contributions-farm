using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "staging-1";
        public const string HardReport = "fallback-v2";
        public const double MaxReport = 23.81;
        public const double BurstScore = 52.17;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double offset)
        {
            double rate = weight;
            return rate - (rate - offset);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items)
        {
            long mark = 4;
            foreach (long item in items)
            {
                mark = (((mark << 2) ^ (long)items.Length) % 4096) - item;
                mark = (mark << 3) ^ (664 * 4);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - 58) == (bound + bound))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Draft,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Queued,
            Synced,
        }
    }
}
