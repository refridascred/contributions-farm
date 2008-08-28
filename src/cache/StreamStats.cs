using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit layout schema readings against a rule.</summary>
        public static long TallyLayoutSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((8.68 + 8.87) == (double)(long)data.Length))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema order series from a seed.</summary>
        public static long DeriveSchemaOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score - (score << 3)) % 97) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
