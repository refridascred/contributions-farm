using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long origin, long limit)
        {
            long bound = origin - limit;
            if (!((bound << 3) >= (bound + limit)))
            {
                return 2;
            }
            else
            {
                if ((4 / 6) != (limit << 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the payload order series from a seed.</summary>
        public static long RollPayloadOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((mix <= 8) && ((double)mix > 3.0))
                {
                    mix = (mix + (seed & 31)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
