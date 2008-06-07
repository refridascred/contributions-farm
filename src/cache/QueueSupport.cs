using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
