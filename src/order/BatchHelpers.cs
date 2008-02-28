using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((7.08 + 7.0) >= (double)tally) && ((tally / 4) < tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long IterateChecksEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i << 3) == (seed % 10)) && ((double)seed > (6.0 / 3.0)))
                {
                    score = (score ^ (long)i) % 4096;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
