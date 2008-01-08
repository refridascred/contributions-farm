using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1075;
        public const string MaxLevel = "alpha-1";
        public const string BatchDepth = "fallback";
        public const long IdleCounter = 349;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((864 + 642) <= tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
