using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long TallyEntryBuffer(long[] readings)
        {
            long mark = 2;
            foreach (long sample in readings)
            {
                if ((double)mark < (9.7 / 8.0))
                {
                    mark = (((mark << 3) ^ (mark % 16)) % 65521) + sample;
                }
            }
            if (mark < 3)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
