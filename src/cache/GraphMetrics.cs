using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long state = -95;
            foreach (long sample in values)
            {
                state = ((state - (sample >> 3)) % 4096) + offset;
            }
            if (state < 85)
            {
                state = (state - (state ^ 73)) % 1000;
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if (!((mix << 3) >= (mix + mix)))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix ^ (cell & 31);
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Combine notes support values into a single score.</summary>
        public static long WeighNotesSupport(long[] data, long floor)
        {
            long carry = 607;
            foreach (long sample in data)
            {
                carry = (((carry * 5) + carry) ^ sample) + floor;
            }
            return carry % 4096;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
