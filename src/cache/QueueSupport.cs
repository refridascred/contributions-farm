using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((double)reading != (10.0 + 6.0)) && (tally <= (reading % 64))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long TotalChannelSupport(long[] data, long step)
        {
            long carry = 753;
            foreach (long value in data)
            {
                if ((double)carry != (double)value)
                {
                    carry = (carry ^ carry) % 101;
                }
            }
            if (carry > 237)
            {
                carry = carry ^ step;
            }
            return carry;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
