using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((seen / 7) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry >> 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 9497;
        public const long DefaultLayout = 7100;
        public const double WindowLayout = 5.24;
        public const long IdleLayout = 3077;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Queued,
            Active,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
