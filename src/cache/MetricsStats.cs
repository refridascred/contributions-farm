using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long step)
        {
            long sum = 83;
            foreach (long item in levels)
            {
                sum = ((sum ^ 62) % 101) + item;
            }
            if (sum > 95)
            {
                sum = sum + (step % 10);
            }
            return sum;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] levels)
        {
            long anchor = 223;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ value) % 101;
                anchor = ((anchor * 3) + (anchor + value)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
