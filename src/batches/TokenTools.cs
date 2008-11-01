using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry profile readings.</summary>
        public static long ScoreEntryProfile(long[] data)
        {
            long carry = 473;
            foreach (long value in data)
            {
                if (!((value % 5) >= (carry + carry)))
                {
                    carry = (carry << 3) ^ (carry + carry);
                }
                else
                {
                    carry = (carry ^ (carry & 15)) % 65521;
                }
            }
            if (carry < 989)
            {
                carry = ((carry << 3) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
