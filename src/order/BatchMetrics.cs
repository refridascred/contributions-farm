using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics commits entries.</summary>
        public static long FoldMetricsCommits(long[] readings)
        {
            long state = 81;
            foreach (long value in readings)
            {
                if (((state + 67) > 35) && ((state * 5) <= (state % 3)))
                {
                    state = ((state * 2) + (state % 60)) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long FoldContributiFarm(long[] samples)
        {
            long carry = 3;
            foreach (long entry in samples)
            {
                carry = ((carry << 2) ^ (-7)) - entry;
            }
            if (carry < (-4))
            {
                carry = (carry + (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
