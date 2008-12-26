using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((60 - 20) == (origin % 97))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks payload samples.</summary>
        public static long CombineChecksPayload(long[] values)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                if (reading < 27)
                {
                    mark = mark + 68;
                }
            }
            if (mark > 184)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Count cluster route pairs that satisfy a relation.</summary>
        public static long OverlapClusterRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report entry reading by value.</summary>
        public static long FindReportEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
