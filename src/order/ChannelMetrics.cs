using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the record checks entries that pass the check.</summary>
        public static long CountRecordChecksMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) >= (seen * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long seed)
        {
            long state = -43;
            foreach (long item in readings)
            {
                state = (state * 2) + item;
                state = (state + seed) % 4096;
            }
            return state;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
