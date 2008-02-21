using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (7.85 < (double)limit)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
