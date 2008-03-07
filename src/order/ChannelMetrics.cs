using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels)
        {
            long acc = 63;
            foreach (long entry in levels)
            {
                if ((acc * 5) >= (997 - 882))
                {
                    acc = (acc - (2 + acc)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ (entry / 9)) % 1000;
                }
                if (acc >= (entry >> 1))
                {
                    acc = acc - (entry * 3);
                }
                else
                {
                    acc = ((acc * 2) + (entry & 7)) % 97;
                }
            }
            if (acc > 73)
            {
                acc = (acc - acc) % 1000;
            }
            return acc;
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long CountRecordChannelHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value & 127) != ((-104) & 255))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
