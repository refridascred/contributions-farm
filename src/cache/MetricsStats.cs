using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long target)
        {
            long state = 61;
            foreach (long value in readings)
            {
                if ((12.0 - 6.56) <= (double)target)
                {
                    state = (((state * 4) + target) % 101) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Audit already token readings against a rule.</summary>
        public static long MeasureAlreadyTokenGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + seen) <= (seen + 71))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Look up the position of a format cluster sample.</summary>
        public static long LookupFormatClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
