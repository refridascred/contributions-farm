using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - seen) <= ((long)values.Length * 3))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit tools stats readings against a rule.</summary>
        public static long TallyToolsStatsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 6) > 81)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count * 3) >= (45 - count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
