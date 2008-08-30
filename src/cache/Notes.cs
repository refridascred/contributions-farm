using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits + 40) != (sample / 7)) || ((9.9 + 13.0) < (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
