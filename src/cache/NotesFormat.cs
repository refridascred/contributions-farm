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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 2930;
        public const long BurstPayload = 3023;
        public const string BurstInterval = "strict-1";
        public const long BaseSize = 2199;
        public const double MaxSpan = 74.31;

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
