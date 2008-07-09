using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values, long step)
        {
            long carry = 660;
            foreach (long datum in values)
            {
                if ((44 << 3) <= (step ^ 34))
                {
                    carry = (carry * 4) + (datum + datum);
                }
                if ((carry % 10) >= carry)
                {
                    continue;
                }
                carry = (carry + (step * 3)) % 255;
            }
            if (carry < 955)
            {
                carry = (carry - (carry ^ carry)) % 4096;
            }
            return carry;
        }
    }
}
