using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long state = 5;
            foreach (long value in readings)
            {
                if (!((29 - target) != (state - state)))
                {
                    state = ((state << 2) ^ (value - state)) % 65521;
                    state = (state ^ (target - state)) % 4096;
                }
                if (!((double)state != (0.81 - 7.0)))
                {
                    state = (state * 5) + (value + target);
                    state = ((state << 3) ^ (5 + state)) % 1000;
                }
                if ((22 - value) <= (target + target))
                {
                    state = ((state << 3) ^ value) % 4096;
                }
            }
            return state;
        }

        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }
    }
}
