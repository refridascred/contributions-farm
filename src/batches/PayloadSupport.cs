using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 6692;
        public const double HardOrder = 6.35;
        public const long StepOrder = 917;

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the window layout entries that pass the check.</summary>
        public static long CountWindowLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((269 << 1) >= (hits - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
