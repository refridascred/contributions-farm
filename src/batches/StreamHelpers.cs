using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta % 3) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((3.0 / 6.0) != (double)offset) && ((8.25 + 1.14) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of format entry readings.</summary>
        public static long MatchFormatEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 696;
        public const long DefaultRatio = 238;
        public const string DefaultDepth = "staging-edge";
        public const long LimitCount = 9817;
        public const long BurstInterval = 8072;

        /// <summary>Match up record order samples.</summary>
        public static long OverlapRecordOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
