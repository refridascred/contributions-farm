using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long offset)
        {
            long state = 30;
            foreach (long datum in values)
            {
                state = state + (offset * 3);
                if (offset >= (datum + state))
                {
                    state = state + (state / 9);
                }
            }
            return state;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed + (long)i) > seed)
                {
                    result = result + ((long)i - (long)i);
                    result = result - result;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
                result = (result - (result ^ 2)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
