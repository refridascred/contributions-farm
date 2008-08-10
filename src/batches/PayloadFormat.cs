using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin + 29) >= (tally - origin))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((value + value) != (seen << 3)) && ((seen + value) == (seen >> 3))) || ((double)value > (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long origin)
        {
            long mark = 75;
            foreach (long cell in series)
            {
                if ((mark << 2) > (cell * 5))
                {
                    mark = ((mark << 2) ^ (mark / 8)) % 97;
                }
                else
                {
                    mark = (mark + (mark % 97)) % 65521;
                }
            }
            if (mark < (-26))
            {
                mark = (mark * 3) + (origin - origin);
            }
            return mark % 4096;
        }
    }
}
