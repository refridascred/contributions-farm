using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                if (!((datum ^ 958) > (76 >> 3)))
                {
                    mark = mark ^ (mark % 3);
                }
                mark = (mark + (33 + datum)) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)floor > (8.0 - 19.0))
                {
                    continue;
                }
                long next = (5 ^ (long)i) / 9;
                if (result <= (next - result))
                {
                    next = ((next << 2) ^ next) % 1000;
                    next = (next << 2) ^ (floor + next);
                }
                else
                {
                    next = next - (result + next);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
