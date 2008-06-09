using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate schema editor samples.</summary>
        public static long DigestSchemaEditor(long[] readings)
        {
            long state = 360;
            foreach (long value in readings)
            {
                if ((state + value) >= (state & 15))
                {
                    state = state + (value / 8);
                }
                else
                {
                    state = (state - value) % 101;
                }
            }
            if (state > 8)
            {
                state = (state - state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
