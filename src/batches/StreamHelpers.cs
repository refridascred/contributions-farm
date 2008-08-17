using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit schema session readings against a rule.</summary>
        public static long AuditSchemaSessionHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 12) > (target % 100))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                long hits = (long)i;
                hits = hits + anchor;
                anchor = (anchor << 3) ^ (hits << 2);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 8;
            foreach (long entry in readings)
            {
                result = (((result << 2) ^ result) % 97) - entry;
            }
            return result;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((43 << 3) > (long)readings.Length)
                {
                    hits = ((hits + 1) + sample) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 3052;
        public const long MaxContext = 6548;
        public const double DefaultContext = 30.01;
        public const long MaxSpan = 7268;
    }
}
