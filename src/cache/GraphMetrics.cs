using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long bound)
        {
            if ((45 + bound) < bound)
            {
                return 4;
            }
            else
            {
                if ((step / 4) == (bound % 64))
                {
                    return 0;
                }
                else
                {
                    if ((bound << 2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)step == (4.44 + 13.0)) && (step <= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
