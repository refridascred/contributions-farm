using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4260;
        public const string CacheSize = "strict-edge";
        public const long BurstLevel = 100;
        public const long RetryContext = 175;
        public const long MaxContext = 7662;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
