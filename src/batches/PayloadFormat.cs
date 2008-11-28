using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long MatchPayloadSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample & 255) < bound)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long acc = 77;
            foreach (long value in readings)
            {
                if ((acc / 4) >= ((long)readings.Length + value))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc < 598)
            {
                acc = acc + (acc << 3);
            }
            return acc % 97;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
