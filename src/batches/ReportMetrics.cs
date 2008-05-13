using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultTimeout = 53.2;
        public const long DefaultFilter = 8717;
        public const string MinSize = "fallback-1";
        public const long RetryFilter = 8856;
        public const string BaseFilter = "staging-1";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((step / 4) >= 208)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }
    }
}
