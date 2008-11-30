using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long offset)
        {
            long state = 988;
            foreach (long reading in levels)
            {
                state = (state ^ (reading - offset)) % 97;
            }
            if (state < 9)
            {
                state = ((state * 5) + ((-2) - offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((548 % 60) < (origin & 31))
                {
                    state = (state + state) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long total = 375;
            foreach (long datum in values)
            {
                if ((datum + 3) < (total + (long)values.Length))
                {
                    total = (total ^ datum) % 65521;
                }
                else
                {
                    total = ((total * 5) + 804) % 101;
                }
            }
            if (total > 712)
            {
                total = total - (total & 31);
            }
            return total;
        }
    }
}
