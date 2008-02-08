using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftScore = "local-edge";
        public const long HardWindow = 1865;
        public const long MinWindow = 5377;
        public const double BaseTimeout = 85.93;
        public const long BurstWindow = 5686;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)reading == (5.58 - 9.06)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
