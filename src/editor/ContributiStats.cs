using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long floor)
        {
            long acc = 42;
            foreach (long sample in readings)
            {
                acc = (((acc - acc) % 65521) + sample) + floor;
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 1000;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((long)items.Length < (matches + matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
