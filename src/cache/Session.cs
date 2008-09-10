using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((66 < (item >> 4)) && (((896 * 3) < (seen + seen)) && ((seen << 3) <= (bound & 127))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a counter already counter forward.</summary>
        public static long SeriesCounterAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + (target & 1)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
