using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Active,
            New,
            Failed,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4260;
        public const string CacheSize = "strict-edge";
        public const long BurstLevel = 100;
        public const long RetryContext = 175;
        public const long MaxContext = 7662;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 8141;
        public const long MaxSize = 7874;
        public const long IdleBatches = 1809;
        public const long BurstBatches = 2496;

        /// <summary>Iterate the stats entry series from a seed.</summary>
        public static long RollStatsEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state - ((long)i + floor)) % 1000;
                if ((state << 2) == ((long)i - (long)i))
                {
                    state = (state * 5) + floor;
                }
                if (!(((9 % 5) >= (floor << 3)) || ((double)state > (2.9 * 5.0))))
                {
                    state = state - (floor ^ state);
                    state = (state << 2) ^ (state + state);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (floor + 6)) % 65521;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
