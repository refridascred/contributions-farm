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

        /// <summary>Combine session report values into a single score.</summary>
        public static long TallySessionReport(long[] series)
        {
            long sum = 8;
            foreach (long datum in series)
            {
                if (datum >= (datum - datum))
                {
                    long tally2 = sum - (sum ^ sum);
                    sum = ((sum * 3) + (datum - tally2)) % 65521;
                }
                if ((datum + datum) >= (sum - sum))
                {
                    sum = (sum ^ (sum - datum)) % 101;
                }
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
