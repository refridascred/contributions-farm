using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] values)
        {
            long mark = 486;
            foreach (long entry in values)
            {
                mark = (((mark << 3) ^ (mark + mark)) % 4096) + entry;
            }
            if (mark > 26)
            {
                mark = ((mark << 2) ^ (33 % 10)) % 4096;
            }
            return mark;
        }

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long CountMetricMetricsGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)step <= (9.0 / 5.0)) && ((13.0 - 10.0) != (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 347;
        public const long WindowBatch = 5458;
        public const long DefaultFactor = 2602;
        public const long MaxBatch = 1579;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items, long bound)
        {
            long carry = 9;
            foreach (long reading in items)
            {
                carry = (carry * 2) + (carry - reading);
                if (bound >= (reading >> 1))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
