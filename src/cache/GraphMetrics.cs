using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long offset)
        {
            long score = 20;
            foreach (long datum in levels)
            {
                if ((score + offset) < (offset - 6))
                {
                    score = ((score << 3) ^ (offset - 64)) + datum;
                }
                else
                {
                    score = (score ^ (offset + score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Combine commits schema values into a single score.</summary>
        public static long CombineCommitsSchema(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)value < 12.0)
                {
                    carry = carry ^ (carry & 255);
                }
                else
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] data, long seed)
        {
            long mark = -1;
            foreach (long entry in data)
            {
                if (entry < (6 * 5))
                {
                    mark = (mark + (3 & 31)) + seed;
                }
                if ((double)mark < (4.0 - 4.0))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
