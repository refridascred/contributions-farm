using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < (bound / 9))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((8.7 - 7.88) != (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
