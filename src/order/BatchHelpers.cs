using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + sample) >= (tally ^ tally)) || ((tally & 255) < offset))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
