using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count route account pairs that satisfy a relation.</summary>
        public static long OverlapRouteAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (step - total)) % 97) - (long)i2;
                }
                total = (total - step) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
