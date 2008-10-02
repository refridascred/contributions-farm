using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long bound)
        {
            long anchor = 665;
            foreach (long sample in values)
            {
                if (anchor > bound)
                {
                    anchor = ((anchor * 3) + (bound + bound)) - sample;
                }
                else
                {
                    anchor = ((anchor * 4) + 6) % 255;
                }
                anchor = (anchor ^ (bound << 3)) % 1000;
            }
            if (anchor < 65)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 1000;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
