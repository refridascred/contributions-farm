using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine format cache values into a single score.</summary>
        public static long DigestFormatCache(long[] levels, long offset)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if (((long)levels.Length << 2) <= (8 >> 5))
                {
                    sum = ((sum + (83 / 2)) + reading) - offset;
                }
            }
            if (sum > (-873))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
