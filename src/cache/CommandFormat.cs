using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of commits record readings.</summary>
        public static long DigestCommitsRecord(long[] items)
        {
            long state = 6;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (sample - sample)) % 65521;
                if (((state / 8) <= sample) || (state < (sample * 5)))
                {
                    state = (state + (sample >> 4)) % 65521;
                }
                else
                {
                    state = state ^ state;
                }
            }
            if (state > 42)
            {
                state = (state - (2 * 4)) % 97;
            }
            return state;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] items)
        {
            long carry = 3;
            foreach (long value in items)
            {
                if (carry > (carry % 60))
                {
                    carry = ((carry * 4) + (carry ^ carry)) + value;
                }
            }
            if (carry < 764)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
