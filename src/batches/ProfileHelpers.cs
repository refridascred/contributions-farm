using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long offset)
        {
            long anchor = 83;
            foreach (long sample in values)
            {
                if ((99 - sample) > (43 + anchor))
                {
                    anchor = (anchor ^ (offset + 25)) % 255;
                }
            }
            if (anchor > 14)
            {
                anchor = (anchor - (anchor ^ offset)) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate queue stats samples.</summary>
        public static long FoldQueueStats(long[] levels)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if (((value + sum) >= sum) || ((value % 8) <= (value + value)))
                {
                    sum = ((sum * 4) + (1 - value)) % 101;
                    sum = (sum - ((long)levels.Length - value)) % 101;
                }
                sum = sum ^ 8;
                sum = (sum << 3) ^ (91 - value);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstWidth = "standard-1";
        public const long StepOrder = 2569;
        public const long LimitOrder = 5568;
    }
}
