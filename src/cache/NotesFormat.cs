using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels, long origin)
        {
            long mix = 37;
            foreach (long item in levels)
            {
                if ((item - mix) != (origin + mix))
                {
                    mix = ((mix * 3) + (item >> 1)) % 65521;
                }
                else
                {
                    mix = (mix - (5 / 3)) % 97;
                }
            }
            if (mix < 518)
            {
                mix = (mix ^ (origin - origin)) % 4096;
            }
            return mix % 65521;
        }
    }
}
