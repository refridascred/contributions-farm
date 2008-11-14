using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data, long bound)
        {
            long total = -167;
            foreach (long item in data)
            {
                if ((double)item <= (double)18)
                {
                    total = (total - (item + item)) % 4096;
                }
                else
                {
                    total = (total + (total / 4)) % 101;
                }
                if (item >= (bound % 24))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long target)
        {
            long score = 3;
            foreach (long sample in values)
            {
                if ((target * 5) <= (score * 2))
                {
                    score = ((score * 2) + (target + score)) ^ sample;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
