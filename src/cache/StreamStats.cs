using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine window metric values into a single score.</summary>
        public static long DigestWindowMetric(long[] data)
        {
            long total = 17;
            foreach (long value in data)
            {
                if ((((long)data.Length * 2) < (total + total)) && ((total * 3) < total))
                {
                    total = (total + (321 * 5)) ^ value;
                }
            }
            if (total < (-514))
            {
                total = ((total << 3) ^ (total - 644)) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a context metric sample.</summary>
        public static long LookupContextMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
