using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((entry + seen) == (seen - seen)) && ((8.0 / 9.0) >= (double)entry)) || ((entry + seen) <= (seen % 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
