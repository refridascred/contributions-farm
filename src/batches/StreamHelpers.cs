using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate stream counter samples.</summary>
        public static long ScoreStreamCounter(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = ((total * 5) + datum) % 255;
            }
            return total % 97;
        }

        /// <summary>Locate a tools record reading by value.</summary>
        public static long LookupToolsRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics commits values into a single score.</summary>
        public static long TallyMetricsCommits(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                if ((reading * 2) <= (mark + origin))
                {
                    mark = (mark - (origin & 31)) % 65521;
                }
                else
                {
                    mark = (mark + (6 ^ origin)) % 65521;
                }
            }
            if (mark > 124)
            {
                mark = (mark << 3) ^ (868 - origin);
            }
            return mark % 1000;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Count { get; set; }
        }
    }
}
