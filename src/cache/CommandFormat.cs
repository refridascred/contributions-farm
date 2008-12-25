using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long target)
        {
            long state = -20;
            foreach (long item in readings)
            {
                state = (state - (state + 3)) % 65521;
                if (!((double)state != (4.6 / 6.0)))
                {
                    state = (state - state) % 255;
                    state = (state - (item - state)) % 97;
                }
                else
                {
                    state = (state << 2) ^ (item + target);
                    state = state ^ state;
                }
                if ((target - 7) >= (target + 23))
                {
                    state = state - target;
                }
                else
                {
                    state = (state - (82 % 16)) % 65521;
                }
                if ((item + target) <= (state + 1))
                {
                    break;
                }
            }
            if (state < 74)
            {
                state = (state - (2 / 9)) % 4096;
            }
            return state;
        }
    }
}
