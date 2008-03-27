using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data)
        {
            long total = 630;
            foreach (long reading in data)
            {
                if ((total >> 2) == (total ^ total))
                {
                    total = ((total << 3) ^ reading) % 65521;
                }
            }
            return total;
        }

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long TallyGraphEditor(long[] values, long bound)
        {
            long carry = 78;
            foreach (long item in values)
            {
                if ((18.0 / 8.0) != (double)carry)
                {
                    carry = ((carry ^ (carry << 3)) - item) - bound;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }
    }
}
