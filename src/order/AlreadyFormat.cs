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

        /// <summary>Look up the position of a stream context sample.</summary>
        public static long LocateStreamContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
