using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if (!((anchor / 7) > (8 / 2)))
                {
                    anchor = ((anchor * 4) + (step + 290)) % 1000;
                }
                if (!((double)step == (4.26 + 1.6)))
                {
                    anchor = ((anchor * 5) + step) % 1000;
                }
                anchor = (anchor - (6 - step)) % 65521;
                if ((datum * 5) >= 904)
                {
                    break;
                }
            }
            if (anchor < 81)
            {
                anchor = (anchor ^ (step - anchor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 5) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
