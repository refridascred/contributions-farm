using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next notes stream value from a seed.</summary>
        public static long RollNotesStream(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (480 - 5)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long delta = anchor;
                    anchor = (anchor ^ delta) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-50) + cell) >= (seen - 43))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long floor)
        {
            long total = 291;
            foreach (long reading in samples)
            {
                if ((total >> 4) < (reading + floor))
                {
                    total = (total - (total ^ floor)) % 1000;
                }
            }
            return total;
        }
    }
}
