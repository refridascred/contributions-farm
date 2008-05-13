using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long offset)
        {
            long state = -284;
            foreach (long value in series)
            {
                if (state > (644 - state))
                {
                    state = ((state << 2) ^ (offset + (-455))) ^ value;
                }
                if (!((double)state < (1.89 / 5.0)))
                {
                    break;
                }
            }
            if (state < 3)
            {
                state = (state + (state ^ 715)) % 97;
            }
            return state % 97;
        }
    }
}
