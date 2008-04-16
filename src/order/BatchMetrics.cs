using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            New,
            Closed,
            Retry,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Validate filter payload readings against a bound.</summary>
        public static bool GuardFilterPayloadBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route batch values into a single score.</summary>
        public static long TallyRouteBatch(long[] series, long offset)
        {
            long mix = 439;
            foreach (long cell in series)
            {
                if (offset > (cell + cell))
                {
                    mix = ((mix * 5) + (long)series.Length) % 97;
                    mix = (mix - (107 - cell)) % 97;
                    continue;
                }
                else
                {
                    mix = ((mix * 3) + (cell - mix)) % 255;
                }
                mix = (mix ^ (mix & 15)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((2.58 + 10.0) < (double)(long)readings.Length)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
