using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first editor stream entry that matches the target.</summary>
        public static long SeekEditorStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Dropped,
            Done,
            Ready,
            Locked,
        }
    }
}
