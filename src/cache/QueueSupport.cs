using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of account counter readings.</summary>
        public static long CombineAccountCounter(long[] data, long seed)
        {
            long state = -445;
            foreach (long cell in data)
            {
                state = ((state << 2) ^ (cell - 87)) % 97;
            }
            if (state > 23)
            {
                state = ((state << 3) ^ (seed >> 2)) % 255;
            }
            return state;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public bool Size { get; set; }
        }
    }
}
