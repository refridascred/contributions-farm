using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Measure how many session counter samples are out of range.</summary>
        public static long MeasureSessionCounterHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample - (long)series.Length) != (seen / 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool VerifyEditorEntryRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
