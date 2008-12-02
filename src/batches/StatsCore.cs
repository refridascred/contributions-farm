using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long origin)
        {
            long state = 9;
            foreach (long item in readings)
            {
                state = ((state ^ (state & 31)) + item) - origin;
            }
            if (state < 136)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Match up batches counter samples.</summary>
        public static long MatchBatchesCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSize = 2643;
        public const long HardSpan = 983;
        public const string BaseProfile = "primary-edge";
    }
}
