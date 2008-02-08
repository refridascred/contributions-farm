using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseTimeout = 9559;
        public const string BurstWidth = "strict-v2";
        public const long IdleRatio = 423;
        public const long BatchProfile = 6321;

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftAlready = 58.78;
        public const long StepFactor = 4716;
        public const string DefaultFactor = "primary-edge";
        public const long MaxSize = 1917;

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
