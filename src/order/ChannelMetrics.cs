using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report cluster entries.</summary>
        public static long WeighReportCluster(long[] levels, long floor)
        {
            long state = 82;
            foreach (long value in levels)
            {
                if ((double)floor <= (double)5)
                {
                    state = (state - (value & 127)) % 4096;
                }
            }
            if (state > 933)
            {
                state = ((state << 3) ^ (floor ^ floor)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long floor)
        {
            long carry = 342;
            foreach (long reading in readings)
            {
                if (9.3 <= (double)carry)
                {
                    carry = (carry + (reading + (long)readings.Length)) - floor;
                }
                else
                {
                    carry = ((carry * 5) + (carry % 64)) % 255;
                }
            }
            if (carry > 70)
            {
                carry = ((carry * 4) + carry) % 65521;
            }
            return carry % 4096;
        }
    }
}
