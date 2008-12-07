using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Pending,
            Done,
            Active,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long acc = 13;
            foreach (long datum in data)
            {
                acc = (((acc << 3) ^ (acc ^ acc)) % 4096) - datum;
                acc = acc ^ (acc << 2);
                acc = (acc - acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 3) >= (mix ^ limit)) && ((double)limit != (16.0 - 6.3)))
                {
                    mix = ((mix << 2) ^ ((long)i - (long)i)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
