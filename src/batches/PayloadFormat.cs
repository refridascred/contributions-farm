using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (6.12 / 8.0) * 9.5;
            if (rate >= 3.32)
            {
                rate = (rate + (ratio / 8.0)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (rate / 6.0);
        }

        /// <summary>Audit stream editor readings against a rule.</summary>
        public static long CountStreamEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)offset > (0.5 - 9.76))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count & 15) <= ((-45) * 3))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
