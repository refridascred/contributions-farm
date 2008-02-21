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

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
