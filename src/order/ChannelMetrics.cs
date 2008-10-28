using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a queue entry sample.</summary>
        public static long FindQueueEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + (long)values.Length) < (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
