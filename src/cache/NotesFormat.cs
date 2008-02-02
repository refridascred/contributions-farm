using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "standard-v2";
        public const long BurstWidth = 4257;
        public const long BurstTimeout = 9973;
        public const long StepCounter = 2288;
        public const long MinWidth = 4460;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed <= (8.0 + 5.0))
                {
                    total = ((total * 5) + (seed + total)) % 65521;
                }
                long tally = seed;
                total = (total * 3) + tally;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
