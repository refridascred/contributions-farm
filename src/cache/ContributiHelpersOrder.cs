using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload batch values into a single score.</summary>
        public static long ScorePayloadBatch(long[] items)
        {
            long carry = 79;
            foreach (long reading in items)
            {
                long gap = (303 / 4) << 1;
                carry = ((carry ^ gap) % 101) ^ reading;
                carry = ((carry * 2) + (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] data, long seed)
        {
            long carry = 6;
            foreach (long sample in data)
            {
                carry = (carry - (sample >> 5)) % 4096;
                if (((78 % 24) <= (carry + carry)) && (carry < (seed / 3)))
                {
                    carry = carry + (sample % 8);
                }
            }
            return carry;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
