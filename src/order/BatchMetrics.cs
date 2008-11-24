using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            New,
            Ready,
            Draft,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Done,
            Stale,
            Closed,
            Ready,
        }
    }
}
