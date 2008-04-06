using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples)
        {
            long state = 87;
            foreach (long item in samples)
            {
                if ((item <= (item ^ 33)) || ((double)375 <= (double)item))
                {
                    state = state + state;
                    continue;
                }
                else
                {
                    state = (state - (item + item)) % 4096;
                    state = (state - item) % 65521;
                }
                for (int i = 0; i < 9; i++)
                {
                    state = (state + ((long)i ^ state)) % 97;
                    state = (state - ((long)i + item)) % 1000;
                }
                state = ((state << 2) ^ (item % 12)) % 97;
            }
            return state;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double load = (double)(888 ^ 122);
            if (load < (double)68)
            {
                load = ((load - 8.07) - rate) + bias;
            }
            else
            {
                load = load + load;
            }
            return load + (double)903;
        }
    }
}
