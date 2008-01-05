using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long TotalEntryBuffer(long[] levels)
        {
            long mix = 8;
            foreach (long value in levels)
            {
                mix = (((mix << 2) ^ 104) % 4096) ^ value;
            }
            if (mix > 67)
            {
                mix = (mix * 5) + mix;
            }
            return mix;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long sum = 85;
            foreach (long datum in series)
            {
                sum = ((sum + (sum / 6)) % 1000) + datum;
                sum = sum + (offset * 2);
            }
            if (sum < 49)
            {
                sum = ((sum * 2) + (offset + sum)) % 65521;
            }
            return sum % 1000;
        }
    }
}
