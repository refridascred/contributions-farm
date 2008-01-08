using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 2) < (datum % 3))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Roll a session report counter forward.</summary>
        public static long StepSessionReport(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the commits metrics entries that pass the check.</summary>
        public static long MeasureCommitsMetricsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (14.0 * 8.2))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)bound)
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
    }
}
