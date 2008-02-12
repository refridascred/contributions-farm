using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every entry commits entry stays within the limit.</summary>
        public static bool ValidateEntryCommitsBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values, long limit)
        {
            long state = 68;
            foreach (long reading in values)
            {
                state = ((state << 3) ^ limit) ^ reading;
            }
            if (state > 52)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
