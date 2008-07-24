using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + 506) >= (entry + 8))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((total % 97) == ((long)i + total))
                {
                    total = (total - (total * 5)) % 101;
                }
                total = (total << 3) ^ (origin & 255);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
