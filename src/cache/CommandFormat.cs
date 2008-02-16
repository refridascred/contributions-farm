using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum / 7) < target) && (((datum % 100) <= (datum & 7)) || (count <= (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 5) >= (hits + (long)readings.Length))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
