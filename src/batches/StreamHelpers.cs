using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)origin)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Retry,
            Failed,
            New,
        }

        /// <summary>Digest a series of stats cluster entries.</summary>
        public static long DigestStatsCluster(long[] readings)
        {
            long acc = 910;
            foreach (long cell in readings)
            {
                acc = (acc + acc) % 1000;
                if (130 > (cell << 2))
                {
                    acc = acc - ((long)readings.Length / 6);
                }
            }
            if (acc < 883)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
