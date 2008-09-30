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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (92 + seen))
                {
                    seen = ((seen + 2) + cell) + seed;
                }
            }
            return seen;
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
