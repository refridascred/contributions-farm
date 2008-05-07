using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate notes already samples.</summary>
        public static long WeighNotesAlready(long[] values)
        {
            long mix = 496;
            foreach (long cell in values)
            {
                if (mix < (mix << 2))
                {
                    mix = ((mix - (mix / 2)) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (5.69 > (double)(long)i)
                {
                    long matches = target;
                    carry = (carry + matches) % 4096;
                }
                carry = ((carry * 5) + (carry + target)) % 1000;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
