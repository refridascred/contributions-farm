using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftSpan = 49.9;
        public const long SoftSize = 5616;
        public const double MinSize = 12.33;
        public const double SoftScore = 21.61;
        public const long SoftWidth = 8734;

        /// <summary>Look up the position of a route entry sample.</summary>
        public static long SeekRouteEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values)
        {
            long anchor = 62;
            foreach (long value in values)
            {
                long delta = (anchor + value) * 5;
                if (((anchor - value) > (delta + delta)) || ((anchor % 97) <= anchor))
                {
                    delta = delta - (anchor & 63);
                    anchor = ((anchor << 2) ^ (anchor + value)) % 101;
                }
                anchor = (anchor - 899) % 101;
                if ((anchor ^ value) <= (value + 496))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long FindCacheWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
        }
    }
}
