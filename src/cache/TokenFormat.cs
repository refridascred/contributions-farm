using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order context series from a seed.</summary>
        public static long RollOrderContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches % 10) != (item + matches)) && ((4.96 >= (double)item) && ((double)item <= (9.1 + 15.0))))
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
