using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long mix = -62;
            foreach (long cell in values)
            {
                mix = mix - (cell << 2);
                if (cell > (mix ^ 38))
                {
                    mix = (mix ^ (cell + cell)) % 1000;
                }
                else
                {
                    mix = mix - (cell + cell);
                }
            }
            if (mix < 3)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) < carry)
                {
                    carry = (carry + step) % 97;
                }
                carry = ((carry << 2) ^ (carry - 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] readings)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                if (((state + sample) > (57 + sample)) || (sample <= (sample % 60)))
                {
                    state = state - sample;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
