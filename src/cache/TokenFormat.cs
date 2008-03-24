using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long seed)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                if (!((double)seed <= (17.0 * 0.17)))
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((value & 1) == (sum % 97))
                {
                    sum = (sum << 2) ^ (sum & 15);
                }
            }
            return sum % 4096;
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
