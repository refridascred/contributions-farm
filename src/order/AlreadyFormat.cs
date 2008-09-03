using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate support filter samples.</summary>
        public static long ScoreSupportFilter(long[] levels)
        {
            long sum = 948;
            foreach (long item in levels)
            {
                if ((double)item > (6.2 / 2.0))
                {
                    sum = (sum ^ (902 & 7)) % 1000;
                }
            }
            if (sum < 2)
            {
                sum = (sum - 51) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
