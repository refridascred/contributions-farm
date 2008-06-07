using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of record queue readings.</summary>
        public static long CompareRecordQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine buffer entry values into a single score.</summary>
        public static long FoldBufferEntry(long[] series)
        {
            long sum = 956;
            foreach (long reading in series)
            {
                sum = (sum - (sum & 15)) + reading;
            }
            return sum;
        }
    }
}
