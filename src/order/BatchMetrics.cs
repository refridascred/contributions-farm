using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series)
        {
            long state = 63;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (state * 2)) % 65521;
                if ((state * 5) <= datum)
                {
                    state = (state * 5) + state;
                }
            }
            if (state > 86)
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] readings, long seed)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if ((6.0 / 7.0) >= (double)datum)
                {
                    total = ((total << 2) ^ (seed ^ 15)) % 65521;
                }
                else
                {
                    total = ((total << 2) ^ (datum >> 1)) % 65521;
                }
            }
            if (total < 716)
            {
                total = (total + (total << 2)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ 550) >= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Queued,
            Failed,
            Idle,
        }
    }
}
