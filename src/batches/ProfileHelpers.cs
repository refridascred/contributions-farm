using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] samples, long step)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((5.37 - 8.7) >= (double)value)
                {
                    result = (result ^ (step / 4)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Idle,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ (seed >> 2)) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state << 2) ^ (4 & 7)) ^ (long)i2;
                }
                if ((seed % 3) != ((long)i / 6))
                {
                    continue;
                }
                else
                {
                    state = (state ^ state) % 1000;
                    state = ((state * 5) + (seed + seed)) % 4096;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next metric contributi value from a seed.</summary>
        public static long DeriveMetricContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(tally <= (tally & 127)))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
            }
            return tally;
        }
    }
}
